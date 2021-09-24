using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWebApp.Models
{
    public class OurDbContext : DbContext
    {
        public OurDbContext(DbContextOptions<OurDbContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
    }
}
