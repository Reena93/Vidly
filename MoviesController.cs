using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModel;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movies mv = new Movies();
            mv.name = "Beauty and beast";

            var cust = new List<customers>
            {
                new customers { name="customer1"},
                new customers { name="customer2"}
            };

            var viewmd = new RandomMovieViewModel();
            viewmd.movie = mv;
            viewmd.customer = cust;
                
            return View(viewmd);
        }
    }
}