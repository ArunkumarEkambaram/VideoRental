using System.Collections.Generic;
using System.Web.Mvc;
using VideoRental_MVC.Models;
using VideoRental_MVC.ViewModel;

namespace VideoRental_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            Movie movie = new Movie { Name = "The Guilty" };
            List<Customer> customers = new List<Customer>
            {
                new Customer{Name="Bathri"},
                new Customer{Name="Pavan"}
            };
            var viewModel = new CustomerMovieViewModel();
            viewModel.Customers = customers;
            viewModel.MovieDetails = movie;

            return View(viewModel);
        }
    }
}