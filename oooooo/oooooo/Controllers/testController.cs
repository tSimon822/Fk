using oooooo.LoginModel;
using oooooo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lis()
        {
            return View();
        }
        public ActionResult Lais()
        {
            return View();
        }
        public ActionResult Lay()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Clogin p)
        {
            tMemberData tMem = (new dbecoDailyEntities()).tMemberData.FirstOrDefault(t => t.fUserId == p.userAccout && t.fPassword == p.userPassword);

            if (tMem == null)
                return View();
            if (tMem.fAuthority == 0)
            {
                Session[CDictionary.ECO_USER_LOGIN] = tMem;
                return RedirectToAction("Lay");
            }
            

            Session[CDictionary.ECO_USER_LOGIN] = tMem;
            return RedirectToAction("Lally");
        }
        public ActionResult Lally()
        {
            return View();
        }
    }
}