using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _35.MovieNight.Areas.Area.Controllers
{
    public class MoviesController : AdminBaseController
    {
        // GET: Area/Movies
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }
    }
}