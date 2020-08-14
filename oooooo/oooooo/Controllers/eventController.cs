using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class EventController : Controller
    {
        // GET: BackEvent
        public ActionResult Event_B()
        {
            dbecoDailyEntities db = new dbecoDailyEntities();
            var events = from t in (new dbecoDailyEntities()).tEvent
                         select t;
            return View(events);

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
            return RedirectToAction("Event_B");
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
            return RedirectToAction("Event_B");
        }
    }
}