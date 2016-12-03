using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class GirisController : Controller
    {
        //
        // GET: /Giris/
        EticaretContext db = new EticaretContext();


        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(string email,string password)
        {
            var deger = db.Kullanicilars.Where(x => x.Email == email && x.Sifre==password).FirstOrDefault();
            if (deger != null)
            {
                //HttpCookie kullanici = new HttpCookie("deger", deger.Ad);
                //Request.Cookies.Add(kullanici);
                Session.Add("deger", deger.Ad);

                return RedirectToAction("index", "Home");
            }
            else
            {
                return RedirectToAction("index", "Giris");


            }


        }
        

    }
}
