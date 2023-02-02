using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Models
{
	[ModelMetadataType(typeof(PersonMetadata))]
	public partial class Person
	{
		public class PersonMetadata
        {
			[Required]
			[MaxLength(100)]

			public string Name { get; set; }
		}
	}
}

