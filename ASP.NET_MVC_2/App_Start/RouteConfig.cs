using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("BlogRoute", "ASP.NET_MVC_2/Blog{action}",
              new { controller = "Test" });
            
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);


            routes.MapRoute("CustomRoute", "{controller}/{action}/{id}",
               new
               {
                   controller = "Test",
                   action = "Index",
                   id = UrlParameter.Optional
               });

           
        }
    }
}
