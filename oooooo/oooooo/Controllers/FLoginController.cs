using oooooo.Models;
using oooooo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class FLoginController : Controller
    {
        // GET: FLogin
        public ActionResult Login()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Login(CforLogin L)
        {
            tMemberData member = (new dbecoDailyEntities()).tMemberData.FirstOrDefault(t => t.fUserId == L.account && t.fPassword == L.password);
            if (member == null)
                return View();

            if (member.fAuthority == 1)
            {
                Session[CDictionary.ECO_ADMIN_LOGIN] = member.fUserId;
                return RedirectToAction("List", "Forum_B");
            }

            Session[CDictionary.ECO_USER_LOGIN] = member.fUserName;
            return RedirectToAction("Home");
        }
        public ActionResult Home()
        {
            var name = Session[CDictionary.ECO_USER_LOGIN];

            return View(name);
        }
        public ActionResult Forget()
        {
            return PartialView();
        }
    }
}