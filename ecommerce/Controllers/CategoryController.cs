using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        [Route("/kategori/{id}")]
        public IActionResult Index(int id)
        {

            category category = new category();


            using (ecommercecontext ecommercecontext = new ecommercecontext())
            {
                category = ecommercecontext.categories.SingleOrDefault(a => a.Id == id);
                //select*from categories where Id == 3
            }
            ViewData["Title"] = category.Name;
            return View(category);
        }
    }
}