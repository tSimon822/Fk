using oooooo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecoBack.Controllers
{
    public class BackFinancialController : Controller
    {
        // GET: BackFinancial
        public ActionResult managementFee()
        {
            var table = from t in (new dbecoDailyEntities()).tManagementFee
                        select t;
            return View(table);
        }
        public ActionResult incomeList()
        {
            var table = from t in (new dbecoDailyEntities()).tIncome
                        select t;
            return View(table);
        }
        public ActionResult incomeKeyIn()
        {
            return View();
        }
        public ActionResult incomeEdit()
        {
            return View();
        }

        public ActionResult payKeyIn()
        {
            return View();
        }
        public ActionResult payList()
        {
            var table = from t in (new dbecoDailyEntities()).tPay
                        select t;
            return View(table);
        }
        public ActionResult financialList()
        {
            return View();
        }
        public ActionResult gasData()
        {
            var table = from t in (new dbecoDailyEntities()).tNaturalGas
                        select t;
            return View(table);
        }
        //public ActionResult gasDataKeyIn()
        //{
            
        //}
        public ActionResult incomeDelete(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction("incomeList");
            }
            dbecoDailyEntities db = new dbecoDailyEntities();
            tIncome t = db.tIncome.FirstOrDefault(x => x.fIcId == Id);
            if (t != null)
            {
                db.tIncome.Remove(t);
                db.SaveChanges();
            }
            return RedirectToAction("incomeList");
        }
        public ActionResult payDelete(int? Id)
        {
            if(Id == null)
            {
                return RedirectToAction("payList");
            }
            dbecoDailyEntities db = new dbecoDailyEntities();
            tPay t = db.tPay.FirstOrDefault(x => x.fPayId == Id);
            if (t != null)
            {
                db.tPay.Remove(t);
                db.SaveChanges();
            }
            return RedirectToAction("payList");
        }
    }
}