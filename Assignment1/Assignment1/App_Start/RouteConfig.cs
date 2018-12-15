using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Maths", "{Controller}/{action}/{a}/{b}", new { }, constraints: new { a = @"^[0-9]+$", b = @"^[0-9]+$" });
            routes.MapRoute("Maths1", "{Controller}/{action}/{a}", new { }, constraints: new { a = @"^[0-9]+$" });
            routes.MapRoute("Person", "{Controller}/{action}/{firstName}/{lastName}", new { }, constraints: new { firstName = @"^[a-z]+[A-Z]+$", lastName = @"^[a-z]+[A-Z]+$" });
            routes.MapRoute("Person1", "{Controller}/{action}/{year}/{month}/{date}", new { }, constraints: new { year = @"^[0-9]+$", month = @"^[0-9]+$", date = @"^[0-9]+$" });
        }
    }
}
