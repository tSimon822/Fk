using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class BackReservationController : Controller
    {
        // GET: BackReservation
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult reservation()
        {
            dbecoDailyEntities db = new dbecoDailyEntities();
            var res = from r in (new dbecoDailyEntities()).tReservation
                      select r;

            return View(res);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tReservation r)
        {


            dbecoDailyEntities db = new dbecoDailyEntities();
            db.tReservation.Add(r);
            db.SaveChanges();


            return RedirectToAction("reservation");
        }


        //修改預約，好像不用修改，頂多取消，所以要改？
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("reservation");

            dbecoDailyEntities db = new dbecoDailyEntities();
            tReservation x = db.tReservation.FirstOrDefault(m => m.fReservationId == id);

            return View(x);
        }

        [HttpPost]
        public ActionResult Edit(tReservation r)
        {
            if (string.IsNullOrEmpty(r.fReservationType))
                return RedirectToAction("reservation");

            dbecoDailyEntities db = new dbecoDailyEntities();
            tReservation ed = db.tReservation.FirstOrDefault(m => m.fReservationId == r.fReservationId);

            if (ed != null)
            {
                ed.fReservationType = r.fReservationType;
                ed.fReservationDate = r.fReservationDate;
                ed.fReservationTimeId = r.fReservationTimeId;
                ed.fnumReservation = r.fnumReservation;
                ed.fRemark = r.fRemark;
                db.SaveChanges();
            }

            return RedirectToAction("reservation");
        }






        //完成通知=刪除

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("reservation");

            dbecoDailyEntities db = new dbecoDailyEntities();
            tReservation x = db.tReservation.FirstOrDefault(m => m.fReservationId == id);
            if (x != null)
            {
                db.tReservation.Remove(x);
                db.SaveChanges();
            }
            return RedirectToAction("reservation");
        }
    }
}