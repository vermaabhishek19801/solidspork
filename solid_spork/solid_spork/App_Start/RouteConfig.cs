using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace solid_spork
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Query",
                url: "{controller}/{action}/{id}/{details}",
                defaults: new { controller = "Query", action = "QueryDetails", id = UrlParameter.Optional }
            );
        }
    }
}