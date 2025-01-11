using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        DbDıomincPortfolioEntities db = new DbDıomincPortfolioEntities();
       
            public ActionResult ContactList()
            {
                var values = db.TblContact.ToList();
                return View(values);
            }
        public ActionResult DeleteContact(int id)
        {
            var values = db.TblContact.Find(id);
            db.TblContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactList");

        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(TblContact p)
        {
           
            db.TblContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpPost]
        public ActionResult SendMessage(TblContact c)
        {
            c.SendDate = DateTime.Now;
            c.IsRead = false;
            db.TblContact.Add(c);
            db.SaveChanges();
            return Redirect("/Default/Index#contact");
        }
       

    }
}