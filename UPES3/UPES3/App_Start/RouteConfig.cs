using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UPES3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "detail",
                url: "Thông-báo/{metaTitle}-{id}",
                defaults: new { controller = "Home", action = "DetailNotification", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Notifications",
               url: "Thông-báo",
               defaults: new { controller = "Home", action = "Notifications", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "TrangCHu",
               url: "Trang-Chủ",
               defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
