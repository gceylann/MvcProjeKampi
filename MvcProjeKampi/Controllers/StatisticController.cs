using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        private Context db = new Context();

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStatisticResult()
        {
            ViewBag.result1 = db.Categories.Count();
            ViewBag.result2 = db.Headings.Where(h => h.CategoryId == 10).Count();
            ViewBag.result3 = db.Writers.Where(w => w.WriterName.Contains("a")).Count();
            ViewBag.result4 = db.Headings.Max(h => h.Category.CategoryName);

            ViewBag.result5 = db.Categories.Where(c => c.CategoryStatus == true).Count() - db.Categories.Where(c => c.CategoryStatus == false).Count();

            return View();
        }

    }
}
