using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var people = ToDoContext.Data.People.Select(p =>
            {
                var displayName = p.DisplayName != "" ? $"({p.DisplayName})" : "";

                return new SelectListItem($"{p.Name} {p.Surame} {displayName}", p.Id.ToString());

            });

            ViewData["People"] = people;

            return View();
        }
    }
}

