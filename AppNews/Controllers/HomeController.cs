using AppNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AppNews.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //List<News> n = new List<News>();
            //using (HttpClient client = new HttpClient())
            //{
            //    n = Newtonsoft.Json.JsonConvert.DeserializeObject<List<News>>(await client.GetStringAsync("http://localhost:51221/api/News"));
            //}
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}