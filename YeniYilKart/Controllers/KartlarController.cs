using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YeniYilKart.Models;

namespace YeniYilKart.Controllers
{
    public class KartlarController : Controller
    {
        private KartContext db = new KartContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Yeni(string ResimAd)
        {
            ViewBag.ResimAd = ResimAd;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Yeni(Kart kart)
        {
            if (ModelState.IsValid)
            {
                db.Kartlar.Add(kart);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Duzenle(int? id)
        {

            var kart = db.Kartlar.FirstOrDefault(x => x.Id == id);
            if (kart == null)
            {
                return HttpNotFound();
            }
            return View(kart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duzenle(Kart kart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(kart);
        }
        public ActionResult Sil(int id)
        {
            var kart = db.Kartlar.FirstOrDefault(x => x.Id == id);
            db.Kartlar.Remove(kart);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
