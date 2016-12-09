using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class DetayController : Controller
    {
        //
        // GET: /Detay/
        EticaretContext db = new EticaretContext();

        public ActionResult Index(int id)
        {
            var deger = db.Urunlers.Where(x => x.id == id).FirstOrDefault();
            return View(deger);
        }

    }
}
