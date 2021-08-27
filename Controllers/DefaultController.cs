using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntitiyFramework;

namespace OgrenciNotMvc.Controllers
{
    public class DefaultController : Controller
    {

        // GET: Default
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var dersler = db.TBLDERSLER.ToList();
            return View(dersler);
        }
        public ActionResult LessonCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LessonCreate(TBLDERSLER les)
        {
            db.TBLDERSLER.Add(les);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var ders = db.TBLDERSLER.Find(id);
            db.TBLDERSLER.Remove(ders);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DersGetir(int id)
        {
            var ders = db.TBLDERSLER.Find(id);
            return View(ders);
        }
        [HttpPost]
        public ActionResult DersGetir(TBLDERSLER ders)
        {
            var d = db.TBLDERSLER.Find(ders.DERSID);
            d.DERSAD = ders.DERSAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}