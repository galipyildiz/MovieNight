using _35.MovieNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _35.MovieNight.Areas.Area.Controllers
{
    [Authorize(Roles = "admin")]//virgül ile 2. bir rol girerek bu yada bu girebilir, diyebililiriz.
    public abstract class AdminBaseController : Controller
    {
        protected ApplicationDbContext db = new ApplicationDbContext();
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}