using _35.MovieNight.Areas.Area.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _35.MovieNight.Areas.Area.Controllers
{
    public class DashboardController : AdminBaseController
    {
        // GET: Area/Dashboard
        public ActionResult Index()
        {
            //SQL: Select Year, Count(*) as Count From Moview Group by Year Order By Year
            List<MovieYearCount> movieYearCounts =
                db.Movies
                .GroupBy(x => x.Year)
                .Select(g => new MovieYearCount()
                {
                    Year = g.Key.Value,
                    Count = g.Count()
                })
                .OrderBy(x=>x.Year)
                .ToList();
            DashboardViewModel vm = new DashboardViewModel()
            {
                MovieYearCounts = movieYearCounts
            };
            return View(vm);
        }
    }
}