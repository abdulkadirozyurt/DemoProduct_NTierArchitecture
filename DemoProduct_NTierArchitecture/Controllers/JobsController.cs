using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entites.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace DemoProduct_NTierArchitecture.Controllers
{
    public class JobsController : Controller
    {
        IJobService jobService = new JobManager(new EfJobDal());

        public IActionResult Index()
        {
            var jobs = jobService.TGetAll();
            return View(jobs);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            jobService.TAdd(job);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteJob(int id)
        {
            var job = jobService.TGetById(id);
            jobService.TDelete(job);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var job = jobService.TGetById(id);

            return View(job);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            jobService.TUpdate(job);

            return RedirectToAction("Index");
        }

    }
}
