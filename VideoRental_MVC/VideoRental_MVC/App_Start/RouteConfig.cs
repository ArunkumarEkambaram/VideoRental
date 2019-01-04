using System.Web.Mvc;
using System.Web.Routing;

namespace VideoRental_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "MovieByReleaseDate",
            //    url: "{controller}/{action}/{month}/{year}",
            //    defaults: new { Controller = "Movies", Action = "ByReleaseDate", month = UrlParameter.Optional, year = UrlParameter.Optional }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
