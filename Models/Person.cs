using System;
namespace ToDoApp.Models
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Issue> Issues { get; set; }
	}

	public enum IssueState
	{
		Todo,
		Doing,
		Done
	}

	class Issue
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
		public IssueState State { get; set; }
		public bool IsUrgent { get; set; }
		public DateTime? Deadline { get; set; }
		public int? AssingedToId { get; set; }
		public Person AssignedTo { get; set; }

	}
}

