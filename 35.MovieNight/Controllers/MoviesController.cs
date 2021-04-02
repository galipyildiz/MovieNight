using _35.MovieNight.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _35.MovieNight.Controllers
{
    public class MoviesController : BaseController
    {
        //ındex koyup query'e movies yazarsan sadece patlar.
        [HttpPost]
        [Authorize]
        //POST: Movies/AddtoFavorites
        public ActionResult AddToFavorites(int id)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null) return HttpNotFound();
            ApplicationUser user = db.Users.Find(User.Identity.GetUserId());
            user.Favorites.Add(movie);
            db.SaveChanges();
            return Json(new { success = true });//anonim nesne
        }
        [HttpPost]
        [Authorize]
        //POST: Movies/RemoveFromFavorites
        public ActionResult RemoveFromFavorites(int id)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null) return HttpNotFound();
            ApplicationUser user = db.Users.Find(User.Identity.GetUserId());
            user.Favorites.Remove(movie);
            db.SaveChanges();
            return Json(new { success = true });
        }
        [Authorize]
        public ActionResult Favorites()
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            return View(user.Favorites.ToList());
        }
    }
}