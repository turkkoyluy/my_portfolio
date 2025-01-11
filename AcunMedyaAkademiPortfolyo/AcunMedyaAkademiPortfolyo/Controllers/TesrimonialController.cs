using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class TesrimonialController : Controller
    {
        DbDıomincPortfolioEntities db = new DbDıomincPortfolioEntities();
        public ActionResult TesrimonialList()
        {
            var values = db.TblTesrimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTesrimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTesrimonial(TblTesrimonial p)
        {
            // Status değeri gönderilmediyse varsayılan olarak false ata
            if (!Request.Form.AllKeys.Contains("Status"))
            {
                p.Status = false;   
            }

            db.TblTesrimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("TesrimonialList");
        }

        public ActionResult DeleteTesrimonial(int id)
        {
            var values = db.TblTesrimonial.Find(id);
            db.TblTesrimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("TesrimonialList");

        }
    }
}