using _35.MovieNight.Models;
using _35.MovieNight.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _35.MovieNight.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(int page = 1)
        {
            IQueryable<Movie> query = db.Movies;
            int totalItems = query.Count();
            int pageSize = 9;
            int totalPages = (int)Math.Ceiling(totalItems / (decimal)pageSize);
            List<Movie> movies = query
                .OrderByDescending(x => x.ImdbRating)//skip kullanabilmek ordeyby kullanmamız gerekiyor.
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            HomeViewModel vm = new HomeViewModel()
            {
                Movies = movies,
                PaginationInfo = new PaginationInfoViewModel()
                {
                    CurrentPage = page,
                    PageSize = pageSize,
                    ItemsOnpage = movies.Count,
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    HasNext = page < totalPages,
                    HasPrevious = page > 1
                }
            };
            
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}