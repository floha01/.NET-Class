using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Articles.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<ArticleModel> Articles { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ArticleModel>().HasData(
                new ArticleModel
                    {
                    Id = 1,
                    Title = "Schraube",
                    Content = "1 cooles Werkzeug",
                    ReleaseDate = DateTime.Now,
                    },
                new ArticleModel
                {
                    Id = 2,
                    Title = "Hammer",
                    Content = "Haut rein!",
                    ReleaseDate = DateTime.Now,
                }
                );
            modelBuilder.Entity<Dog>().HasData(
                new Dog 
                {
                    Id = 3,
                    Name = "Bucky",
                    Race = "Altdeutscher Schäferhund",
                    Age = 6,
                }
                );
        }
    }
}
