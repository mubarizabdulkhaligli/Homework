using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Yummy.DAL;
using Yummy.ViewModels;

namespace Yummy.Controllers
{
    public class HomeController : Controller
    {
        readonly YummyDBContext _context;

        public HomeController(YummyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Categories = _context.Categories.ToList(),
                Meals = _context.Meals
                .Include(x=> x.Category)
                .Include(x=> x.MealIngredients).ThenInclude(x=> x.Ingredient)
                .ToList()
            };

            return View(model);
        }
    }
}