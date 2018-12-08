using AppNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace AppNews.Migrations
{
    public class Services
    {
        public static async Task<List<News>> GetJson(string uri)
        {
            List<News> _list = new List<News>();
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(uri);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await client.GetStringAsync(uri);
                        _list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<News>>(result);
                        return _list;
                    } else
                        return new List<News>();
                }
                catch (Exception)
                {
                    return new List<News>();
                }
            }
        }
    }
}