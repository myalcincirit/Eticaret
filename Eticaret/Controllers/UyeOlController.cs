using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class UyeOlController : Controller
    {
        //
        // GET: /UyeOl/
        EticaretContext db = new EticaretContext();

        public ActionResult Index()
        {
            return View(db.Kullanicilars.FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Kayit(string firstname, string lastname, string email, string telephone, string address_1, string city, string password)
        {
            var deger = db.Kullanicilars.Where(x=>x.Email ==email).FirstOrDefault();
            if ( firstname == "" &&  lastname =="" &&  email=="" &&  telephone== "" &&  address_1 == "" &&  city=="" &&  password=="")
            {
                 return RedirectToAction("index", "UyeOl");

            }
            else
            {
                if (deger != null)
                {

                    return RedirectToAction("index", "UyeOl");

                }
                else
                {
                    Kullanicilar kn = new Kullanicilar();
                    kn.Ad = firstname;
                    kn.Soyad = lastname;
                    kn.Email = email;
                    kn.Tel = telephone;
                    kn.Adress = address_1;
                    kn.Sehir = city;
                    kn.Sifre = password;
                    db.Kullanicilars.Add(kn);
                    db.SaveChanges();
                    return RedirectToAction("index", "Home");

                }
            }
           
           
        }
    }
}
