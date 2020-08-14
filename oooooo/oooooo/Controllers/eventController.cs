using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class eventController : Controller
    {
        dbecoDailyEntities db = new dbecoDailyEntities();
        // GET: event
        public ActionResult Event()
        {
            var table = from t in db.tEvent
                        select t;
            return View(table);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tEvent p)
        {
            dbecoDailyEntities db = new dbecoDailyEntities();
            db.tEvent.Add(p);
            db.SaveChanges();
            return RedirectToAction("Event");
        }

        public ActionResult SetRegistForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetRegistForm(tEventRegister p)
        {
            dbecoDailyEntities db = new dbecoDailyEntities();
            db.tEventRegister.Add(p);
            db.SaveChanges();
            return RedirectToAction("Event");
        }
    }
}