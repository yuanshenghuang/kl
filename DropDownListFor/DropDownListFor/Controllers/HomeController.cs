using DropDownListFor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListFor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var category = new Category();
            category.CategoryList = new[]
                {
                    new SelectListItem{Value="opel" ,Text="opel"},
                    new SelectListItem{Value="Mercedez", Text ="Mercedez"},
                    new SelectListItem{Value ="BMW", Text="BMW"}
                };
            return View(category);
        }

        [HttpPost]
        public ActionResult Index(Category category)
        {
            return Content("Thanks for selecting: " + category.SelectedCategory);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}