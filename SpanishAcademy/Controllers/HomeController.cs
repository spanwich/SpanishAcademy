using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json;
using System.IO;

namespace SpanishAcademy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public string GetClass()
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://spreadsheets.google.com/feeds/list/1rmG59KueHFkXXIsmXLVh-pOFnTMddk7AyDJjrm1CDGU/od6/public/values?alt=json");
            }
            return json;
        }
    }
}