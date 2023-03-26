using Microsoft.AspNetCore.Mvc;
using StevensGameCorner.Models;

namespace StevensGameCorner.Controllers
{
    public class ProductController : Controller
    {
       
        public IActionResult ListProducts()
        {
            List<ProductModel> products = ProductData.GetProducts();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            ProductModel product = ProductData.GetProduct(id);
            return View(product);
        }
    }
}
