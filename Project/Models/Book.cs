using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
    }
}
