using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        //do they own or wish to purchase said book
        public string Status { get; set; }
        //book photo
        //public string BookPhoto { get; set; }
        public IFormFile BookPhoto { get; set; }
    }
}
