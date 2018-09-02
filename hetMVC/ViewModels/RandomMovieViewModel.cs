using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hetMVC.Models;
namespace hetMVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customers> Customers { get; set; }
    }
}