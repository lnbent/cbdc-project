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
            using (var context = new ProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProjectContext>>()))
            {
                // Similar setup found in tutorial, edited to match requested info
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Fahrenheit 451",
                        PublishDate = DateTime.Parse("1953-19-10"),
                        Author = "Ray Bradbury"
                    },

                    new Book
                    {
                        Title = "The Hobbit",
                        PublishDate = DateTime.Parse("1937-21-09"),
                        Author = "J. R. R. Tolkien"
                    },

                    new Book
                    {
                        Title = "One Flew Over the Cuckoo's Nest",
                        PublishDate = DateTime.Parse("1962-1-02"),
                        Author = "Ken Kessey"
                    },

                    new Book
                    {
                        Title = "Little Women",
                        PublishDate = DateTime.Parse("1869-2-12"),
                        Author = "Louisa May Alcott"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
