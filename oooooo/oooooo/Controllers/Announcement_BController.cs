using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class Announcement_BController : Controller
    {
        // GET: Announcement_B
        public ActionResult List()
        {
            dbecoDailyEntities db = new dbecoDailyEntities();
            var tAnnouncements = from p in new dbecoDailyEntities().tAnnouncement
                                 select p;
            return View(tAnnouncements);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tAnnouncement tAnn)
        {
            if (tAnn.fImage != null)
            {
                string photoName = Guid.NewGuid().ToString() + Path.GetExtension(tAnn.fImage.FileName);
                var path = Path.Combine(Server.MapPath("~/image/"), photoName);
                tAnn.fImage.SaveAs(path);
                tAnn.fAnnFilePath = "../image/" + photoName;
            }
            dbecoDailyEntities db = new dbecoDailyEntities();
            db.tAnnouncement.Add(tAnn);
            db.SaveChanges();
            return RedirectToAction("List");
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("List");

            dbecoDailyEntities db = new dbecoDailyEntities();
            tAnnouncement x = db.tAnnouncement.FirstOrDefault(m => m.fAnnouncementId == id);
            return View(x);
        }

        [HttpPost]
        public ActionResult Edit(tAnnouncement tAnn)
        {
            if (string.IsNullOrEmpty(tAnn.fUserId))
                return RedirectToAction("List");

            dbecoDailyEntities db = new dbecoDailyEntities();
            tAnnouncement changetAnn = db.tAnnouncement.FirstOrDefault(m => m.fAnnouncementId == tAnn.fAnnouncementId);
            if (changetAnn != null)
            {
                changetAnn.fAnnDate = tAnn.fAnnDate;
                changetAnn.fAnnTitle = tAnn.fAnnTitle;
                changetAnn.fAnnFilePath = tAnn.fAnnFilePath;
                changetAnn.fAnnContent = tAnn.fAnnContent;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("List");

            dbecoDailyEntities db = new dbecoDailyEntities();
            tAnnouncement x = db.tAnnouncement.FirstOrDefault(m => m.fAnnouncementId == id);
            if (x != null)
            {
                db.tAnnouncement.Remove(x);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}