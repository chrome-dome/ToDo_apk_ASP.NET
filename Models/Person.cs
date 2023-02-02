using System;
namespace ToDoApp.Models
{
	public partial class Person
	{
		public static Person Empty = new();

		public int Id { get; set; }
		public string Name { get; set; } = "";
		public List<Issue> Issues { get; set; }
	}

}

