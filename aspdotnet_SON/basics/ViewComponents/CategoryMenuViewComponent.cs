using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using basics.Data;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {

        private readonly MovieContext _context;

        public CategoryMenuViewComponent(MovieContext context){
            _context = context;
        }


        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"]!.ToString() == "Index")
                ViewBag.SelectedCategory = RouteData?.Values["id"];

            return View(_context.Categories.ToList());
        }
    }
}