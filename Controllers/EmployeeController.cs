using Demo2MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo2MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            return View();
        }

        public IActionResult NewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewEmployee(Employee emp)
        {
            return View();
        }


    }
}
