using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace api_teszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await ListOrders();
        }

        private async Task ListOrders()
        {
            string apiUrl = "https://rendfejl1012.northeurope.cloudapp.azure.com/DesktopModules/Hotcakes/API/REST/v1/orders";
            string apiKey = "1-81247215-0a5d-49c9-9bda-cdae164a9ba8";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("JSON válasz:\n" + json.Substring(0, Math.Min(500, json.Length))); // csak az eleje, hogy ne legyen túl hosszú

                        // Ha tudod a struktúrát, cseréld erre:
                        var parsed = JsonConvert.DeserializeObject<HotcakesOrderResponse>(json);

                        foreach (var order in parsed.Content)
                        {
                            listBox1.Items.Add(order.OrderNumber); // kell egy listBox1 a formon
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen kérés: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt: " + ex.Message);
                }
            }
        }

        public class HotcakesOrderResponse
        {
            public List<OrderInfo> Content { get; set; }
        }

        public class OrderInfo
        {
            public string OrderNumber { get; set; }
            public DateTime OrderDateUtc { get; set; }
            public string StatusCode { get; set; }
            // További mezők az API válasza alapján
        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            await ListOrders();
        }
    }
}
