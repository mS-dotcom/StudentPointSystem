using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntitiyFramework;

namespace OgrenciNotMvc.Controllers
{
    public class PointsController : Controller
    {
        // GET: Points
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var notlar = db.TBLNOTLAR.ToList();
            return View(notlar);
        }
        [HttpGet]
        public ActionResult NewExam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewExam(TBLNOTLAR not)
        {
            db.TBLNOTLAR.Add(not);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var not = db.TBLNOTLAR.Find(id);
            db.TBLNOTLAR.Remove(not);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}