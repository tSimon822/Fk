using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class Forum_BController : Controller
    {
        // GET: Forum_B
        public ActionResult List(int? fId)
        {
            dbecoDailyEntities2 db = new dbecoDailyEntities2();

            var q = from od in db.tForumComment
                    where od.fForumId == fId
                    select new Models.GroupViewModels { fWriter = od.tForum.fWriter, fUserName = od.tMemberData.fUserName, fForumTitle = od.tForum.fForumTitle, fPostDate = od.tForum.fPostDate, fForumImage = od.tForum.fForumImage, fForumContent = od.tForum.fForumContent, fForumComment = od.fForumComment };
            return View(q);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("List");

            dbecoDailyEntities2 db = new dbecoDailyEntities2();
            tForum x = db.tForum.FirstOrDefault(m => m.fForumId == id);
            if (x != null)
            {
                db.tForum.Remove(x);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}