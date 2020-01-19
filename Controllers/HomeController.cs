using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreTrainingProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreTrainingProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronimic = "Иванович",
                Age = 22,
                Position = "Бухгалтер",
            },
            new Employee
            {
                Id = 2,
                FirstName = "Сидор",
                SurName = "Сидоров",
                Patronimic = "Сидорович",
                Age = 23,
                Position = "Бухгалтер",
            }
        };

        // GET: /
        // GET: /home/
        // GET: /home/index
        public IActionResult Index()
        {
            return View(_employees);
        }
        

        // GET: /home/details/{id}
        public IActionResult Details(int id)
        {
            Employee employee = _employees.FirstOrDefault(x => x.Id == id);
            
            if (employee == null)
                return NotFound();

            return View(_employees.FirstOrDefault(x => x.Id == id));
        }
    }
}
