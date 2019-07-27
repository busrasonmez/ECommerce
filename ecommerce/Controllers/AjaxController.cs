using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class AjaxController : Controller
    {
        [Route("/api")]
        public IActionResult Handle() 
        {
            string json = HttpContext.Request.Form["JSON"].ToString();
            Dto.ProductSaveDto productSave = Newtonsoft.Json.JsonConvert.DeserializeObject<Dto.ProductSaveDto>(json);
            using (ecommercecontext ecommercecontext = new ecommercecontext())
            {
                ecommercecontext.Products.Add(new Models.Product()
                {
                    Name = productSave.productName,
                    Description = "boş",
                    State = ,
                    Category=?,
                    CreateDate=DateTime.UtcNow,
                });
            }
            return View();
        }
    }
}