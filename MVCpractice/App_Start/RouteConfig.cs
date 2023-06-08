using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCpractice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Employees",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
     name: "AdminLogin",
     url: "Admins/Login",
     defaults: new { controller = "Admins", action = "Login" }
 );
            routes.MapRoute(
    name: "AdminDashboard",
    url: "Admins/Dashboard",
    defaults: new { controller = "Admins", action = "Dashboard" }
);

            routes.MapRoute(
    name: "EmployeeLogin",
    url: "Employees/Login",
    defaults: new { controller = "Employees", action = "Login" }
);

            routes.MapRoute(
   name: "EmployeeHome",
   url: "Employees/EmployeeHome",
   defaults: new { controller = "Employees", action = "EmployeeHome" }
);

        }
    }
}
