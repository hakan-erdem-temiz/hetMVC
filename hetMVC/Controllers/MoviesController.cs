using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hetMVC.Models;
using hetMVC.ViewModels;

namespace hetMVC.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { id = 1, Name = "Shrek" },
                new Movie { id = 2, Name = "Wall-e" }
            };
        }

        // GET: Movies/Random
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //create a view which has a same name with controller
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                id = 1,
                Name = "Hakan Erdem Temiz"
            };

            var customers = new List<Customers>()
            {
                new Customers{id=1 ,Name="Erdem Temiz"},
                new Customers{id=2, Name="Hakan Temiz"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers,
                Movie = movie
            };

            return View(viewModel);
        }

        //we dont use view so we dont need create new view for this action.
        public ActionResult SampleText(string name)
        {
            return Content("Hello this is sample text:" + name);
        }

        //mvcaction4 quick
        [Route("movies/released/{year}/{month:regex(\\d{2}:range(1,12))}")]
        public ActionResult ReleasedByDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



    }
}