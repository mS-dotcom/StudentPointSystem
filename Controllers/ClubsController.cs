using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntitiyFramework;

namespace OgrenciNotMvc.Controllers
{
    public class ClubsController : Controller
    {
        // GET: Clubs
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var kulüpler = db.TBLKULUPLER.ToList();
            return View(kulüpler);
        }
        public ActionResult CreateClub()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateClub(TBLKULUPLER clb)
        {
            db.TBLKULUPLER.Add(clb);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var kulup = db.TBLKULUPLER.Find(id);
            db.TBLKULUPLER.Remove(kulup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KulüpGetir(int id)
        {
            var kulup = db.TBLKULUPLER.Find(id);
            return View(kulup);
        }
        [HttpPost]
        public ActionResult KulüpGetir(TBLKULUPLER k)
        {
            var kulup = db.TBLKULUPLER.Find(k.KULUPID);
            kulup.KULUPAD = k.KULUPAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}