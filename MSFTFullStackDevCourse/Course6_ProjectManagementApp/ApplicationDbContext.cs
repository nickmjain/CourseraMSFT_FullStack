using Microsoft.EntityFrameworkCore;
using System;

namespace Course6_ProjectManagementApp
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=ProductDB;User=root;Password=Speakers@1;",
                ServerVersion.AutoDetect("Server=localhost;Database=ProductDB;User=root;Password=Speakers@1;")
                );
        }
    }
}
