using System;
using System.ComponentModel.DataAnnotations;

namespace cbdc_project.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime YearPublished { get; set; }
        public string Author { get; set; }
    }
}
