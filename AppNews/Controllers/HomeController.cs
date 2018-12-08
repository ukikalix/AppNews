using AppNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppNews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<News> _news = Migrations.Services.GetJson("http://localhost:51221/api/News").Result.ToList();
            return View(_news);
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