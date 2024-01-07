using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Data;
using MovieApp.Models;
using basics.Entity;
using basics.Data;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {

        private readonly MovieContext _context;

        public MovieController(MovieContext context){
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // ---------------------------

        [HttpGet]
        
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(),"Id","Name") ;
            return View(new Movie());
        }

        [HttpPost]
        
        public IActionResult Create(Movie m)
        {
            if(ModelState.IsValid){
                //MovieRepository.AddMovie(m);
                _context.Movies.Add(m);
                _context.SaveChanges();

                return RedirectToAction("Index","Home");
            }

            ViewBag.Categories = new SelectList(_context.Categories.ToList(),"Id","Name") ;

            return View(m);
            
        }


        // ---------------------------



        //----------------------------
        [HttpGet]
        public IActionResult Edit(int id)
        {

            ViewBag.Categories = new SelectList(_context.Categories.ToList(),"Id","Name") ;
            return View(_context.Movies.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            //MovieRepository.EditMovie(m);
            _context.Movies.Update(m);
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
            
        }

        //-----------------------------

        [HttpPost]
        public IActionResult Delete(int Id)
        {

            
            //MovieRepository.DeleteMovie(Id);

            var entity = _context.Movies.Find(Id);

            _context.Movies.Remove(entity!);
            _context.SaveChanges();


            return RedirectToAction("Index","Home");
        }



        public IActionResult Details()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}