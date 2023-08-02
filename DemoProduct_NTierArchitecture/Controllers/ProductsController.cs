using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concretes;
using DataAccess.EntityFramework;
using Entites.Concretes;

namespace DemoProduct_NTierArchitecture.Controllers
{
    public class ProductsController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        public IActionResult Index()
        {
            var products = productManager.TGetAll();

            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productManager.TAdd(product);
            return RedirectToAction("Index");
        }

    }
}
