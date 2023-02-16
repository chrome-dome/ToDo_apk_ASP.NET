using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
        [ModelMetadataType(typeof(IssueMetadata))]
        public partial class Issue
        {
            public class IssueMetadata
            {

                [Required]
                [MaxLength(200)]
                [Display(Name = "Tytuł")]
                public string Title { get; set; } = "";

                [Display(Name = "Notatka")]
                public string Notes { get; set; } = "";

                [Display(Name = "Status")]
                public IssueState State { get; set; }

                [Display(Name = "Pilne")]
                public bool? IsUrgent { get; set; }

                [Display(Name = "Ostateczny Termin")]
                public DateTime? Deadline { get; set; }

                public int? AssingedToId { get; set; }

                [Display(Name = "Osoba")]
                public Person AssignedTo { get; set; } = Person.Empty;

        }
        }
}

