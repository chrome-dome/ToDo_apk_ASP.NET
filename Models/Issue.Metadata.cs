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
                public string Title { get; set; } = "";

                [Required]
                public string Notes { get; set; } = "";

                }
        }
}

