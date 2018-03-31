using ASPpractice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPpractice_1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}