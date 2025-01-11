using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        DbDıomincPortfolioEntities db = new DbDıomincPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbaout.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicesPartical()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult TesrimonialPartial()
        {
            var values = db.TblTesrimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult ProjectPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactPartial()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
           
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult JsPartial()
        {
            return PartialView();
        }



    }
}