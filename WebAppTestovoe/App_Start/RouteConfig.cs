using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebAppTestovoe.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoute(RouteCollection routes)
        {
            routes.MapPageRoute("admin_products", "admin/products", "~/Pages/Admin/Products.aspx");
        }
    }
}