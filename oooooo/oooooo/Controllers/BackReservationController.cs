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
    }
}