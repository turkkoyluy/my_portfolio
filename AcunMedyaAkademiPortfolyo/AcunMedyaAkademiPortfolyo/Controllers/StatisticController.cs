using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class StatisticController : Controller
    {
        DbDıomincPortfolioEntities db = new DbDıomincPortfolioEntities(); //sınıftan nesne türetme
        public ActionResult Index()
        {
            ViewBag.categorysayisi = db.TblCategory.Count();
            ViewBag.projesayisi = db.TblProject.Count();
            return View();
        }
    }
}