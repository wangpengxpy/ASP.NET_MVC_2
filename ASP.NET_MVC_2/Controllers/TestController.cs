using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_2.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Test";
            ViewBag.Action = "Index";
            return View("DisplayActionView");
        }

        public ActionResult MyBlog(string id = "MyBlogId")
        {
            ViewBag.Controller = "Test";
            ViewBag.Action = "MyBlog";
            ViewBag.CustomVariable = id;
            return View();
        }
    }
}