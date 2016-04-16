using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Product";
            ViewBag.Action = "Index";
            return View("DisplayActionController");
        }
        public ActionResult ListProducts()
        {
            ViewBag.Controller = "Product";
            ViewBag.Action = "ListProducts";
            return View("DisplayActionController");
        }
    }
}