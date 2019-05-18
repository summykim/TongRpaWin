using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MqAgent
{
    class RestExecutor
    {
        public static async Task GetHttp(String url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("/sendMqMessage");
                if (response.IsSuccessStatusCode)
                {
                    String message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Id:{0}\tName:{1}", message, message);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }

        }
    }
}
