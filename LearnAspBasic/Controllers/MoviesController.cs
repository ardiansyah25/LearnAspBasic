    using LearnAspBasic.Models;
using LearnAspBasic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnAspBasic.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                   Id = 1,
                   Name = "Jaka Tingkir",
                },
                new Movie
                {
                    Id = 2,
                    Name = "Mak Lampir"
                }
            };
        }



        /* public ActionResult Random()
         {
             var movie = new Movie() { Name = "Ardiansyah" };
             var customers = new List<Customer>
             {
                 new Customer { Name = "Customer 1"},
                 new Customer {Name = "Customer 2"},
             };

             var viewModel = new RandomMovieViewModel()
             {
                 Movie = movie,
                 Customers = customers
             };

             return View(viewModel);

         }

         public ActionResult Edit(int id)
         {
             return Content("id=" + id);
         }

         public ActionResult Index(int? pageIndex, string sortBy)
         {
             if (!pageIndex.HasValue)
             {
                 pageIndex = 1;
             }

             if (string.IsNullOrWhiteSpace(sortBy))
             {
                 sortBy = "Name";
             }
             return Content(String.Format("pageindex={0}&sortBy={1}",pageIndex,sortBy));
         }

         [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
         public ActionResult ByReleaseDate(int year, int month)
         {
             return Content(year + "/" + month);
         }*/


    }
}