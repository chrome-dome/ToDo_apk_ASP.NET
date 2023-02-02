using System;
namespace ToDoApp.Models
{
	public class ToDoContext
	{
		public List<Issue> Issues { get; set; }
		public List<Person> People { get; set; }
	}
}

