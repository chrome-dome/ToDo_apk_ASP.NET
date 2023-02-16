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
			[MaxLength(50)]

			public string Name { get; set; } = "";
            public string Surame { get; set; } = "";

            [Required]
            [MaxLength(10)]
            public string DisplayName { get; set; } = "";
        }
	}
}

