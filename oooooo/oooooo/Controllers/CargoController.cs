using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class CargoController : Controller
    {
        // GET: Cargo
        public ActionResult Cargo()
        {
            //2020-08-16
            dbecoDailyEntities db = new dbecoDailyEntities();
            var package = from t in (new dbecoDailyEntities()).tCargo
                          select t;
            return View(package);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tCargo p)
        {
            dbecoDailyEntities db = new dbecoDailyEntities();
            db.tCargo.Add(p);
            db.SaveChanges();
            return RedirectToAction("Cargo");
        }

    }
}