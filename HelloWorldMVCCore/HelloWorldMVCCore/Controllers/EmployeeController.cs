using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldMVCCore.Models;
using HelloWorldMVCCore.ProjectDatabaseContext;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVCCore.Controllers
{
    public class EmployeeController : Controller
    {
        private ProjectDbContext db;
        public EmployeeController(ProjectDbContext projectDbContext)
        {
            db = projectDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

     
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(model);

                bool isSaved = db.SaveChanges() > 0;
                if (isSaved)
                {
                    ViewBag.Message = "Saved Successful!";
                }
                
            }
            ModelState.Clear();
            return View();

        }

        public IActionResult Search()
        {
            var employees = db.Employees.ToList();
            return View(employees);
        }
    }
}
