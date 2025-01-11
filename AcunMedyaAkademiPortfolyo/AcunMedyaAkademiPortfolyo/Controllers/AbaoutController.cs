using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class AbaoutController : Controller
    {
        DbDıomincPortfolioEntities db = new DbDıomincPortfolioEntities();
        public ActionResult AbaoutList()
        {
            var values = db.TblAbaout.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbaout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbaout(TblAbaout p)
        {
            db.TblAbaout.Add(p);
            db.SaveChanges();
            return RedirectToAction("AbaoutList");
        }
        public ActionResult DeleteAbaout(int id)
        {
            var values = db.TblAbaout.Find(id);
            db.TblAbaout.Remove(values);
            db.SaveChanges();
            return RedirectToAction("AbaoutList");

        }
    }
}