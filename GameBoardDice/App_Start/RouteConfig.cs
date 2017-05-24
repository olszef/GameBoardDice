using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GameBoardDice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ProductDetails",
                url: "game-detail-{id}",
                defaults: new { controller = "Store", action = "Details" }
            );

            routes.MapRoute(
                name: "StaticPages",
                url: "info/{viewname}.html",
            defaults: new { controller = "Home", action = "StaticContent" }
            );

            routes.MapRoute(
                name: "ProductList",
                url: "kategorie/{category}",
                defaults: new { controller = "Store", action = "List" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
