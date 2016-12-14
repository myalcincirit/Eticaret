using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class YonetimController : Controller
    {
        string rol = "1";
        //
        // GET: /Yonetim/
        EticaretContext db = new EticaretContext();
        string ResimKaydetSlider(HttpPostedFileBase file)
        {
            Image orj = Image.FromStream(file.InputStream);
            Bitmap kkck = new Bitmap(orj, 360, 185);
            Bitmap buyuk = new Bitmap(orj, 750, 400);


            string yol = Path.GetFileNameWithoutExtension(file.FileName) + Guid.NewGuid() + Path.GetExtension(file.FileName);
            buyuk.Save(Server.MapPath("~/image/slider/" + yol));
            kkck.Save(Server.MapPath("~/image/YanResim/" + yol));
            return yol;
        }
        public ActionResult SliderAdd()
        {

            return View(db.Sliders.FirstOrDefault());
        }
        [HttpPost]
        public ActionResult SliderAdd(IEnumerable<HttpPostedFileBase> Slider1, HttpPostedFileBase resim1, HttpPostedFileBase resim2)
        {

            Slider sl = new Slider();
            string yol1 = ResimKaydetSlider(resim1);
            sl.BirResimYolu = "/image/YanResim/" + yol1;
            string yol2 = ResimKaydetSlider(resim2);
            sl.BirResimYolu = "/image/YanResim/" + yol2;
            foreach (var item in Slider1)
            {
                string cyoll = ResimKaydetSlider(item);

                sl.ResimYolu = "image/slider/"+cyoll;

            }

            return View("index");
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Giris(string text, string password)
        {
            var deger = db.Admins.Where(x => x.KullaniciAdi == text && x.Sifre == password).FirstOrDefault();
            if (deger != null)
            {
                Session.Add("deger", "1");
                return RedirectToAction("Details", "Yonetim");
            }
            else
            {
                return RedirectToAction("index", "Yonetim");
            }
        }

        //
        // GET: /Yonetim/Details/5

        public ActionResult Details()
        {
            if (Session["deger"].ToString()==rol)
            {
                return View(db.Urunlers.ToList());

            }
            else
            {
                return RedirectToAction("index", "Yonetim");

            }
        }

        //
        // GET: /Yonetim/Create

        public ActionResult Create()
        {
            return View();
        }
        string ResimKaydet(HttpPostedFileBase file)
        {
            Image orj = Image.FromStream(file.InputStream);
            Bitmap kkck = new Bitmap(orj, 60, 60);
            Bitmap kck = new Bitmap(orj, 200, 200);
            Bitmap buyuk = new Bitmap(orj, 360, 360);


            string yol = Path.GetFileNameWithoutExtension(file.FileName) + Guid.NewGuid() + Path.GetExtension(file.FileName);
            buyuk.Save(Server.MapPath("~/image/buyuk/" + yol));
            kck.Save(Server.MapPath("~/image/kck/" + yol));
            kkck.Save(Server.MapPath("~/image/kkck/" + yol));
            return yol;
        }

        //
        // POST: /Yonetim/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection,Urunler urn,HttpPostedFileBase resim)
        {
            
            if (Session["deger"].ToString() ==rol)
            {

                string yol = ResimKaydet(resim);
                urn.UrunResimYol = "image/buyuk/" + yol;
                urn.kUrunResim = "image/kck/" + yol;
                urn.kkUrunResim = "image/kkck/" + yol;
                try
                {
                    db.Urunlers.Add(urn);
                    db.SaveChanges();

                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("index", "Yonetim");

            }
            
        }

        //
        // GET: /Yonetim/Edit/5

        public ActionResult Edit(int id)
        {
            
            return View(db.Urunlers.Where(x => x.id == id).FirstOrDefault());
        }

        //
        // POST: /Yonetim/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection,Urunler urn,HttpPostedFileBase resim)
        {
            try
            {
                string yol = ResimKaydet(resim);
                urn.UrunResimYol = "image/buyuk/" + yol;
                urn.kUrunResim = "image/kck/" + yol;
                urn.kkUrunResim = "image/kkck/" + yol;
                // TODO: Add update logic here
                db.Entry(urn).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Yonetim/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Yonetim/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
