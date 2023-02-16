using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
        public enum IssueState
        {
            [Display(Name = "Do zrobienia")]
            Todo,
            [Display(Name = "W trakcie")]
            Doing,
            [Display(Name = "Zrobione")]
            Done
        }
}

