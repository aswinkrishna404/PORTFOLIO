using Microsoft.EntityFrameworkCore;
using PORTFOLIO.Models;

namespace PORTFOLIO.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        public DbSet<Project> ProjectList { get; set; }
        public DbSet<Contact> ContactForm { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData
                (
                new Project
                {
                    Id = 1,
                    Name = "website",
                    Description = "Description",
                    Link = "#"

                }
                );
        }
    }
    
}
    