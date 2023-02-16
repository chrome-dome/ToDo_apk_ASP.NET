using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
	public partial class Issue
	{
            public int Id { get; set; }
            public string Title { get; set; } = "";
            public string Notes { get; set; } = "";
            public IssueState State { get; set; }
            public bool IsUrgent { get; set; }
            public DateTime? Deadline { get; set; }
            public int? AssingedToId { get; set; }
            public Person AssignedTo { get; set; } = Person.Empty;
    }
}

