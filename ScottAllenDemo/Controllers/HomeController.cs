using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScottAllenDemo.Models;

namespace ScottAllenDemo.Controllers
{
    public class HomeController : Controller
    {
        ScottDb scottDb = new ScottDb();

        public ActionResult Index()
        {
            var model = scottDb.Restaurants.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Pete";
            model.Location = "Birmingham";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (scottDb != null)
            {
                scottDb.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}