using System;
namespace ToDoApp.Models
{
	public partial class Person
	{
		public static Person Empty = new Person();

		public int Id { get; set; }
		public string Name { get; set; } = "<empty>";
		public string Surame { get; set; } = "<empty>";
		public string DisplayName { get; set; } = "";
		//public List<Issue> Issues { get; set; }
	}

}

