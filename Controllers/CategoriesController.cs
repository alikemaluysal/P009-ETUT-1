using CoreMVC.Models;
using CoreMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index(string? value)
        {
            ViewBag.Success = value;
            return View(categoryRepository.GetAll());
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryRepository.Add(category);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var categoryToDelete = categoryRepository.GetById(id);
            categoryRepository.Delete(categoryToDelete);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var category = categoryRepository.GetById(id); //1 Roman
            return View(category);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            categoryRepository.Update(category);
            
            return RedirectToAction("Index", "Categories",new{ value="1"});
        }


    }
}
