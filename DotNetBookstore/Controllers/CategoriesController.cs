using Microsoft.AspNetCore.Mvc;
using DotNetBookstore.Models;
using DotNetBookstore.Views;

namespace DotNetBookstore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            // use category model to generate 10 categories in memory for display in the view
            // this is a placeholder for the actual category model
            var categories = new List<Category>();
            for (int i = 1; i <= 10; i++)
            {
                categories.Add(new Category
                {
                    CategoryId = i,
                    Name = "Category " + i
                });
            }

            return View(categories);
        }

        public IActionResult Browse(string category)
        {
            if (category == null)
            {
                // If no category is selected, redirect to the Index action.
                return RedirectToAction("Index");
            }
            // Display the selected category using ViewBag object.
            ViewBag.category = category;

            // Return a default view to ensure all code paths return a value.
            return View();
        }
    }
}
