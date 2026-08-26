using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Models;

namespace SchoolApp.Data
{
    public class SchoolDbContext : DbContext
    {
      public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options){}
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Major> Majors => Set<Major>();

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
              modelBuilder.Entity<Product>()
                  .Property(product => product.Price)
                  .HasPrecision(18, 2);
          }
    }
}
