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
        public static async Task<List<News>> GetJsonAsync(string param)
        {
            string uri = "http://localhost:51221/api/" + param;
            List<News> _list = new List<News>();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    _list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<News>>(await client.GetStringAsync(uri));
                    return _list;
                }
                catch (Exception)
                {
                    return new List<News>();
                }
            }
        }
    }
}