using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScottAllenDemo.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(String name)
        {
            var massage = Server.HtmlEncode(name);

            return Content("Hello");
        }
    }
}