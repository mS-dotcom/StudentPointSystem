using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvc.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.snc = "";
            return View();
        }
        [HttpPost]
        public ActionResult Index(int sayi1,int sayi2)
        {
            ViewBag.snc = "Sonuç :" + (sayi1 + sayi2);
            return View();
        }
    }
}