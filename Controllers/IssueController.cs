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

        [HttpGet]
        public IActionResult Create()
        {

            ViewData["People"] = GetSelectLists();

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var issue = ToDoContext.Data.Issues.FirstOrDefault(i => i.Id == id);

            if (issue==null)
            {
                return RedirectToAction("Error404", "Error");
            }

            ViewData["People"] = GetSelectLists();

            return View(issue);
        }

        [HttpPost]
        public IActionResult Edit(int id, [FromForm]Issue issue)
        {
            if (id != issue.Id)
            {
                return RedirectToAction("Error400", "Error");
            }

            if (!ModelState.IsValid)
            {
                return View(issue);
            }

            var updatedIssue = ToDoContext.Data.Issues.FirstOrDefault(i => i.Id == id);

            if (updatedIssue == null)
            {
                return RedirectToAction("Error400", "Error");
            }

            updatedIssue.Title = issue.Title;
            updatedIssue.State = issue.State;
            updatedIssue.IsUrgent = issue.IsUrgent;
            updatedIssue.Deadline = issue.Deadline;
            updatedIssue.Notes = issue.Notes;

            return View(issue);
        }


        [HttpPost]
        public IActionResult Create([FromForm] Issue issue)
        {
            if (!ModelState.IsValid)
            {
                ViewData["People"] = GetSelectLists();

                return View(issue);
            }

            if (issue.AssignedToId != null)
            {
                issue.AssignedTo = ToDoContext.Data.People
                    .FirstOrDefault(m => m.Id == issue.AssignedToId, Person.Empty);
            }

            issue.Id = ToDoContext.Data.Issues.Max(i => i.Id) + 1;
            ToDoContext.Data.Issues.Add(issue);

            return RedirectToAction("Index");
        }

        private IEnumerable<SelectListItem> GetSelectLists()
        {
            return ToDoContext.Data.People.Select(p =>
            {
                var displayName = p.DisplayName != "" ? $"({p.DisplayName})" : "";

                return new SelectListItem($"{p.Name} {p.Surame} {displayName}", p.Id.ToString());

            });
        }
    }
}

