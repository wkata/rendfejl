using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Controls;

namespace kliensalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12; // HTTPS fix
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task UpdateOrderStatusAsync(string orderNumber, string newStatus)
        {
            string apiKulcs = "1-81247215-0a5d-49c9-9bda-cdae164a9ba8";
            string apiURL = $"https://rendfejl1012.northeurope.cloudapp.azure.com/DesktopModules/Hotcakes/API/rest/v1/orders/?key={apiKulcs}";

            var payload = new
            {
                OrderNumber = orderNumber,
                Status = newStatus // A frissített státusz
            };

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsJsonAsync(apiURL, content);  // PUT kérés a frissítéshez
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string orderNumber = textBox1.Text.Trim();

            try
            {
                var orderInfo = await GetOrderDetailsAsync(orderNumber);

                if (orderInfo != null)
                {
                    rendszam.Text = orderInfo.OrderNumber;
                    renddatum.Text = orderInfo.ExpectedDelivery.ToString("yyyy.MM.dd");

                    megrendelesd.Text = orderInfo.OrderPlaced.ToString("yyyy.MM.dd");
                    csomagolvad.Text = orderInfo.Packed.ToString("yyyy.MM.dd");
                    postarad.Text = orderInfo.Shipped.ToString("yyyy.MM.dd");
                    kikuldesd.Text = orderInfo.Dispatched.ToString("yyyy.MM.dd");
                    atveteld.Text = orderInfo.Delivered.ToString("yyyy.MM.dd");
                    UpdateProgressBar(orderInfo);
                }
                else
                {
                    MessageBox.Show("Nem található rendelés a megadott számmal.", "Nincs találat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatok lekérdezése során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string newStatus = "Completed";
            try
            {
                await UpdateOrderStatusAsync(orderNumber, newStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a rendelés frissítése során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async Task<OrderInfo> GetOrderDetailsAsync(string orderNumber)
        {
            string apiKulcs = "1-81247215-0a5d-49c9-9bda-cdae164a9ba8";
            string apiURL = $"https://rendfejl1012.northeurope.cloudapp.azure.com/DesktopModules/Hotcakes/API/rest/v1/orders?key={apiKulcs}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiURL);
                if (!response.IsSuccessStatusCode)
                {
                    string err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Hiba: {response.StatusCode}\n{err}");
                    return null;
                }

                string json = await response.Content.ReadAsStringAsync();
                var parsed = JsonConvert.DeserializeObject<HotcakesOrderResponse>(json);

                var validOrders = parsed.Content.Where(o => !string.IsNullOrWhiteSpace(o.OrderNumber)).ToList();
                var order = validOrders.FirstOrDefault(o => o.OrderNumber == orderNumber);
                if (order == null)
                    return null;

                var orderPlaced = ConvertJsonDate(order.TimeOfOrderUtc);
                Random rnd = new Random();

                var packed = orderPlaced.AddDays(rnd.Next(1, 3));
                var shipped = packed.AddDays(rnd.Next(1, 2));
                var dispatched = shipped.AddDays(rnd.Next(1, 2));
                var delivered = dispatched.AddDays(rnd.Next(1, 2));
                var expected = delivered;
                // Tracking number (12 random digits)
                string trackingNumber = string.Concat(Enumerable.Range(0, 12).Select(_ => rnd.Next(0, 10).ToString()));
                DateTime today = DateTime.Now.Date;
                int shippingStatus = 1; // Unshipped alapértelmezés

                if (today == packed.Date)
                    shippingStatus = 2; // PartiallyShipped
                else if (today > packed.Date)
                    shippingStatus = 3; // FullyShipped
                                        // StatusName beállítása if-else alapján
                string statusName;
                if (shippingStatus == 1 || shippingStatus == 2)
                {
                    statusName = "Ready for Shipping";
                }
                else if (shippingStatus == 3)
                {
                    statusName = "Completed";
                }
                else
                {
                    statusName = "Unknown";
                }
                return new OrderInfo
                {
                    OrderNumber = order.OrderNumber,
                    OrderPlaced = orderPlaced,
                    Packed = packed,
                    Shipped = shipped,
                    Dispatched = dispatched,
                    Delivered = delivered,
                    ExpectedDelivery = expected,
                    TrackingNumber = trackingNumber,
                    ShippingStatus = shippingStatus,
                    StatusName = statusName
                };
            }
        }

        public class OrderInfo 
        {
            public string OrderNumber { get; set; }
            public DateTime OrderPlaced { get; set; }
            public DateTime Packed { get; set; }
            public DateTime Shipped { get; set; }
            public DateTime Dispatched { get; set; }
            public DateTime Delivered { get; set; }
            public DateTime ExpectedDelivery { get; set; }
            public string TrackingNumber { get; set; }
            public int ShippingStatus { get; set; } // 0–4 értékek
            public string StatusName { get; set; }
            
        }

        private void UpdateProgressBar(OrderInfo order)
        {
            int progress = 0;
            DateTime today = DateTime.Now.Date;

            if (order.Delivered.Date <= today)
                progress = 100;
            else if (order.Dispatched.Date <= today)
                progress = 80;
            else if (order.Shipped.Date <= today)
                progress = 60;
            else if (order.Packed.Date <= today)
                progress = 40;
            else if (order.OrderPlaced.Date <= today)
                progress = 20;

            progressBar1.Value = progress;
            progressBar1.ForeColor = Color.Green; // csak látványosabbá tételhez, opcionális
        }
        public class HotcakesOrderResponse
        {
            public List<OrderDTO> Content { get; set; }
        }

        public class OrderDTO
        {
            public string OrderNumber { get; set; }
            public string TimeOfOrderUtc { get; set; }
        }

        private DateTime ConvertJsonDate(string rawDate)
        {
            var match = System.Text.RegularExpressions.Regex.Match(rawDate, @"\/Date\((\d+)\)\/");

            if (match.Success && long.TryParse(match.Groups[1].Value, out long millis))
            {
                return DateTimeOffset.FromUnixTimeMilliseconds(millis).UtcDateTime;
            }

            return DateTime.MinValue;
        }
        

    }
}
