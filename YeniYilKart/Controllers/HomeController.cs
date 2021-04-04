using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeniYilKart.Models;

namespace YeniYilKart.Controllers
{
    public class HomeController : Controller
    {
        KartContext db = new KartContext();
        public ActionResult Index()
        {
            return View(db.Kartlar.ToList());
        }
        public ActionResult Indir()
        {
            string yol = Server.MapPath("~/Images/");
            DirectoryInfo directoryInfo = new DirectoryInfo(yol);
            FileInfo[] files = directoryInfo.GetFiles("*.png*");
            List<string> lst = new List<string>(files.Length);
            foreach (var item in files)
            {
                lst.Add(item.Name);
            }
            return View(lst);
        }
        public ActionResult Indirilen(string filename)
        {
            if (Path.GetExtension(filename)==".png")
            {
                string tumYol = Path.Combine(Server.MapPath("~/Images/"), filename);
                return File(tumYol, "~/Images/png");
            }
            else
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.Forbidden);
            }
        }
    }
}