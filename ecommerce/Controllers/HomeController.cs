using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (ecommercecontext ecommercecontext = new ecommercecontext())
            {
                List<user> Users = ecommercecontext.users.Include(a=> a.addresses).ToList();
                List<address> addresses = ecommercecontext.addresses.Include(a => a.user).ToList();
            }  
            return View(); 
        }      
    }
}
