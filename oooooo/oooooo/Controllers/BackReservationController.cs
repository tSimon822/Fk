using oooooo;
using oooooo.Models;
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
        dbecoDailyEntities db = new dbecoDailyEntities();
        public ActionResult Index(int? Id)
        {
            var table = from t in db.tReservation
                        select new Models.reservationViewModel
                        {
                            fReservationId = t.fReservationId,
                            fReservationTime = t.tReservationTime.fReservationTime,
                            fReservationType = t.fReservationType,
                            fUserId = t.fUserId,
                            fRemark = t.fRemark,
                            fnumReservation = t.fnumReservation,
                            fReservationDate = t.fReservationDate
                        };
            return View(table);
        }
    }
}