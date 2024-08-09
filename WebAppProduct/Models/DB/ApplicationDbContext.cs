using Microsoft.EntityFrameworkCore;
using static WebAppProduct.Models.DB.DataBaseClass;

namespace WebAppProduct.Models.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Electronics" },
                new Category { CategoryId = 2, Name = "Books" });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Laptop", Price = 1200, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Headphones", Price = 100, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Novel", Price = 15, CategoryId = 2 });
        }
    }
}
