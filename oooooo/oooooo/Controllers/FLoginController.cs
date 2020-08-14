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
                return RedirectToAction("List", "Forum_B");

            return RedirectToAction("Home");
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Forget()
        {
            return PartialView();
        }
    }
}