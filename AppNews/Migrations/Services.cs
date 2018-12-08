using AppNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppNews.Migrations
{
    public class Services
    {
        public static async System.Threading.Tasks.Task<List<News>> GetJson(string uri)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<News>>(await client.GetStringAsync(uri));
            }
        }
    }
}