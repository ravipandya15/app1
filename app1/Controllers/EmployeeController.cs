using app1.Data.Context;
using app1.Data.Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly TestDBContext dbContext;
        public EmployeeController(TestDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public List<Employee> GetEmployee()
        {
            List<Employee> employees = this.dbContext.Employee.ToList();
            return employees;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
