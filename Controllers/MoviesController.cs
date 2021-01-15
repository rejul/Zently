using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zently.Models;
using System.Data.Entity;
using Zently.ViewModels;

namespace Zently.Controllers
{
    
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;


        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        //GET: mOVIES

        public ActionResult Index()
        {
            var movie = _context.Movies.Include(m => m.Genre).ToList();
            return View(movie);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
        
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name= "TENET"};
            var customers = new List<Customer>
             {
                 new Customer{Name="Customer1"},
                 new Customer { Name="Customer2"}
             };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };
             return View(viewModel);
        }






       // //Movies/ByReleaseDate
       // [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
       // public ActionResult ByReleaseYear(int year,int month)
       //{
       //    return Content(year + "/" + month);
       // }

    }
}