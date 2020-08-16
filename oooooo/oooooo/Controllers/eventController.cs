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

        public ActionResult Edit(int? id)
        {
            if (id == null)
            return RedirectToAction("Event_B");

            dbecoDailyEntities db = new dbecoDailyEntities();
            tEvent x = db.tEvent.FirstOrDefault(m => m.fEventId == id);
            return View(x);
        }
        
            
        [HttpPost]
        public ActionResult Edit(tEvent p)
        {
            if (string.IsNullOrEmpty(p.fEventTitle))
                return RedirectToAction("List");
            dbecoDailyEntities db = new dbecoDailyEntities();
            tEvent editevent = db.tEvent.FirstOrDefault(m => m.fEventId == p.fEventId);
            if (editevent != null)
            {
                editevent.fEventTitle = p.fEventTitle;
                editevent.fCategory = p.fCategory;
                editevent.fEventFromDay = p.fEventFromDay;
                editevent.fEventEndDate = p.fEventEndDate;
                editevent.fUserId = p.fUserId;
                editevent.fEventImgPath = p.fEventImgPath;
                editevent.fEventDay = p.fEventDay;
                editevent.fEventTime = p.fEventTime;
                editevent.fEventLocation = p.fEventLocation;
                editevent.fEventDescription = p.fEventDescription;
                editevent.fEventFee = p.fEventFee;
                editevent.fnumCourse = p.fnumCourse;
                editevent.fRemark = p.fRemark;
                db.SaveChanges();
            }
            return RedirectToAction("Event_B");
        }

        public ActionResult Detail()
        {
            dbecoDailyEntities db = new dbecoDailyEntities();
            var details = from t in (new dbecoDailyEntities()).tEventRegister
                         select t;
            return View(details);
        }

       



    }
}