﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScottAllenDemo.Models;

namespace ScottAllenDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = $"{controller}::{action} {id}";

            ViewBag.Message = message;
            return View();
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
    }
}