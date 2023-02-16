using System;
namespace ToDoApp.Models
{
	public class ToDoContext
	{
		public List<Issue> Issues { get; set; } = new List<Issue>();
		public List<Person> People { get; set; } = new List<Person>();

		public static ToDoContext Data = new ToDoContext
		{
			People =
			{
				new Person() { Id = 1, Name = "Adam", Surame = "Jarząbek", DisplayName = "ajar" },
				new Person() { Id = 2, Name = "Dariusz",Surame = "Drozd",DisplayName = "ddro" },
				new Person() { Id = 3, Name = "Paweł",Surame = "Sabuk",DisplayName = "psab" },
				new Person() { Id = 4, Name = "Weronika",Surame = "Łukaszewicz",DisplayName = "wluk" }
			},

			Issues =
			{
				new Issue
				{
					Id = 1,
					Title = "Create ToDo aplication",
					IsUrgent = true,
					Deadline = DateTime.Now.AddMonths(1),
					State = IssueState.Todo,
					Notes = "It is very important to show my skills to the future employer"
                },
				new Issue
				{
					Id = 2,
					Title = "Style the front end",
					IsUrgent = false,
					Deadline = DateTime.Now.AddDays(14),
					State = IssueState.Doing,
					Notes = "The app will look nice"
                },
				new Issue
				{
					Id = 3,
					Title = "Connecting with DB",
					Deadline = DateTime.Now.AddDays(30),
					State = IssueState.Todo,
					Notes = "Without a database, the application is useless"
                },
				new Issue
				{
					Id = 4,
					Title = "Check operation",
					State = IssueState.Done,
					Notes = "Testing the operation of the application"
                }
			}

		};

		static ToDoContext()
		{
			Data.Issues[0].AssignedTo = Data.People[0];
			Data.Issues[1].AssignedTo = Data.People[2];
		}
	}
}

