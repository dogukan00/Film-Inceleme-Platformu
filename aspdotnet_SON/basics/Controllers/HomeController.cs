using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using basics.Data;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly MovieContext _context;

        public HomeController(MovieContext context){
            _context = context;
        }
        
        public IActionResult Index(int? id ,string q)
        {
            //var movies = MovieRepository.Movies;

            var movies = _context.Movies.AsQueryable();

            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id);
            }

            if(!string.IsNullOrEmpty(q)){

                movies = movies.Where(i => i.Name!.Contains(q) || i.ShortDescription!.Contains(q));

            }

            return View(movies.ToList());
        }

        public IActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }

    

    }
}