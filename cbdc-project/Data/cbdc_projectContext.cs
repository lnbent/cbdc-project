using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cbdc_project.Models;

namespace cbdc_project.Data
{
    public class cbdc_projectContext : DbContext
    {
        public cbdc_projectContext (DbContextOptions<cbdc_projectContext> options)
            : base(options)
        {
        }

        public DbSet<cbdc_project.Models.Books> Books { get; set; }
    }
}
