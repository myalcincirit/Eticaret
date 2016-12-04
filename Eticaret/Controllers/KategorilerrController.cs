using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class KategorilerrController : Controller
    {
        EticaretContext db = new EticaretContext();
        //
        // GET: /Kategorilerr/

        public ActionResult Index(int id)
        {
            var deger = db.Urunlers.Where(x => x.KategoriId == id).ToList();

            return View(deger);
        }

    }
}
