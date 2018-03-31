using ASPpractice_1.Models;
using ASPpractice_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPpractice_1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //return View(movie);
            return View(viewModel);
        }

        /*
         * Constraints:
         *  min, max, minlength, maxlength, int, float, guid
         *  
         *  keywords - ASP.NET MVC Attribute Route Constraints
         * 
         */

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}