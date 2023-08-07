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
    public class CustomersController : Controller
    {
        //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        ICustomerService customerService = new CustomerManager(new EfCustomerDal());

        public IActionResult Index()
        {
            var customers = customerService.TGetAll();

            return View(customers);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult result = customerValidator.Validate(customer);
            if (result.IsValid)
            {
                customerService.TAdd(customer);

                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteCustomer(int id)
        {
            var customer = customerService.TGetById(id);
            customerService.TDelete(customer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var customer = customerService.TGetById(id);
            return View(customer);


        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerService.TUpdate(customer);

            return RedirectToAction("Index");
        }

    }
}
