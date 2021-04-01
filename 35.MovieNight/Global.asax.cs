using _35.MovieNight.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _35.MovieNight
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//kültür değiştirme.
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbSeed.SeedRolesAndUsers();
            DbSeed.SeedMovies().GetAwaiter().GetResult();//işin bitmesini bekle sonucunu al. async metodlarda await diyerek orda bekletiyoruz.
        }
    }
}
