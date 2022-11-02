using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> list = new List<Departments>();

            list.Add(new Departments { Id = 1, Name = "Eletronicos" });
            list.Add(new Departments { Id = 2, Name = "Fashion"});

            return View(list);
        }
    }
}
