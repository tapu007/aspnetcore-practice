using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagemetApp.DatabaseContext;
using EmployeeManagemetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EmployeeManagemetApp.Controllers
{
    public class EmployeeController:Controller
    {
        private EmployeeDbContext _db;

        public EmployeeController(EmployeeDbContext db)
        {
            this._db = db;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            _db.Employees.Add(model);
            bool isSaved = _db.SaveChanges() > 0;
            if (isSaved)
            {
                ViewBag.Message = "Saved Succesful!";
            }
            return View();
        }
    }
}
