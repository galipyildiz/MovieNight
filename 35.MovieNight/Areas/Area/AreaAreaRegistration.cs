using System.Web.Mvc;

namespace _35.MovieNight.Areas.Area
{
    public class AreaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Area";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Area_default",
                "Area/{controller}/{action}/{id}",
                new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}