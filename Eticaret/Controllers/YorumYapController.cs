using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class YorumYapController : Controller
    {
        //
        // GET: /YorumYap/
        EticaretContext db = new EticaretContext();
        public ActionResult Index(int id, string name, string soyad,string email,string text)
        {
            Yorumlar yrm = new Yorumlar();
            yrm.Email = email;
            yrm.Ad = name;
            yrm.SoyAd = soyad;
            yrm.Yorum = text;
            yrm.UrunId = id;
            db.Yorumlars.Add(yrm);
            db.SaveChanges();

            return RedirectToAction("index/"+id+"","detay");
        }

    }
}
