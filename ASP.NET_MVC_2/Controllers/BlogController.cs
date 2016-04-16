using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_2.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Blog";
            ViewBag.Action = "Index";
            return View("DisplayActionView");
        }
        public ActionResult Comments()
        {
            ViewBag.Controller = "Blog";
            ViewBag.Action = "Comments";
            return View("DisplayActionView");
        }
    }
}