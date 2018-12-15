using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
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

            //routes.MapRoute("Home","{Home}/{Index}/{input}", new { }, constraints: new { input = @"^[a-z]+$" });

            //routes.MapRoute("Default", "{controller}/{action}/{id}",new { },constraints:new { id = @"^[a-z]+$" });
        }
    }
}
