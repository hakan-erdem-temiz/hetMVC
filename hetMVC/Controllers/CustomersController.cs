using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hetMVC.Models;
using hetMVC.ViewModels;
using System.Data.Entity;

namespace hetMVC.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        [Route("Customers/")]
        public ActionResult Customers()
        {
            var movie = new Movie()
            {
                id = 001,
                Name = "HET"
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

        [Route("Customers/Details/{cId:regex(\\d{1})}")]
        public ActionResult Details(int? cId)
        {
            var movie = new Movie()
            {
                id = 001,
                Name = "HET"
            };

            var customers = new List<Customers>()
            {
                new Customers{id=1 ,Name="Erdem Temiz"},
                new Customers{id=2, Name="Hakan Temiz"}
            };

            var customersL = new List<Customers>();
            foreach (var cl in customers)
            {
                if (cl.id == cId)
                    customersL.Add(cl);
            }

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customersL,
                Movie = movie
            };

            return View(viewModel);
        }
    }
}