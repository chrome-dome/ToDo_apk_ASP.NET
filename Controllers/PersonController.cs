using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var people = ToDoContext.Data.People;

            return View(people);
        }
    }
}

