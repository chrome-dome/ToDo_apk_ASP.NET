using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class IssueController : Controller
    {
        public IActionResult Index()
        {
            var issues = ToDoContext.Data.Issues;

            return View(issues);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

