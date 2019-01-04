using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRental_MVC.Models;

namespace VideoRental_MVC.ViewModel
{
    public class CustomerMovieViewModel
    {
        public List<Customer> Customers { get; set; }
        public Movie MovieDetails { get; set; }        
    }
}