using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Data;
using System;
using System.Linq;

namespace Project.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //auto populate the table 

            //using (var context = new ProjectContext(
            //    serviceProvider.GetRequiredService<
            //        DbContextOptions<ProjectContext>>()))
            //{
            //    // Similar setup found in tutorial, edited to match requested info
            //    if (context.Book.Any())
            //    {
            //        return;   // DB has been seeded
            //    }

            //    context.Book.AddRange(
            //        new Book
            //        {
            //            Title = "Fahrenheit 451",
            //            PublishDate = DateTime.Parse("1953-10-19"),
            //            Author = "Ray Bradbury",
            //            Status = 
            //        },

            //        new Book
            //        {
            //            Title = "The Hobbit",
            //            PublishDate = DateTime.Parse("1937-9-12"),
            //            Author = "J. R. R. Tolkien",
            //            Status =
            //        },

            //        new Book
            //        {
            //            Title = "One Flew Over the Cuckoo's Nest",
            //            PublishDate = DateTime.Parse("1962-2-1"),
            //            Author = "Ken Kessey",
            //            Status =
            //        },

            //        new Book
            //        {
            //            Title = "Little Women",
            //            PublishDate = DateTime.Parse("1869-12-2"),
            //            Author = "Louisa May Alcott",
            //            Status =
            //        }
            //    );
            //    context.SaveChanges();
            //}
        }
    }
}
