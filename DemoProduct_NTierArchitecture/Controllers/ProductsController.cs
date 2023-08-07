using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Concretes;
using Business.FluentValidation;
using DataAccess.Concretes.EntityFramework;
using Entites.Concretes;
using FluentValidation.Results;

namespace DemoProduct_NTierArchitecture.Controllers
{
    public class ProductsController : Controller
    {
        //ProductManager productManager = new ProductManager(new EfProductDal());
        private IProductService productService = new ProductManager(new EfProductDal());

        public IActionResult Index()
        {
            var products = productService.TGetAll();

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
            ProductValidator productValidator = new ProductValidator();
            ValidationResult results = productValidator.Validate(product);
            if (results.IsValid)
            {
                productService.TAdd(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in results.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteProduct(int id)
        {
            //first step, we will find related entity, second step we will delete it.
            var product = productService.TGetById(id);
            productService.TDelete(product);

            return RedirectToAction("Index");

        }


        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = productService.TGetById(id);

            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {

            productService.TUpdate(product);

            return RedirectToAction("Index");
        }



    }
}
