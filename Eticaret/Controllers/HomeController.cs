using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        EticaretContext db = new EticaretContext();


        public ActionResult Index()
        {     
            return View(db.Urunlers.ToList());
        }
        public ActionResult Slider()
        {
            return View(db.Sliders.ToList());
        }
        public ActionResult BestSeller()
        {
            return View(db.Urunlers.OrderByDescending(x=>x.Tarih).ToList());
        }
        public ActionResult YeniUrunler()
        {
            return View(db.Urunlers.ToList().Take(10));
        }
        public ActionResult Kategoriler()
        {
            return View(db.Kategorilers.ToList());
        }




    }

}
