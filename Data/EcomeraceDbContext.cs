
using Microsoft.EntityFrameworkCore;
using RESTful_API.Models;

namespace RESTful_API.Data
{
    public class EcomeraceDbContext :DbContext
    {

        public EcomeraceDbContext(DbContextOptions<EcomeraceDbContext> options) : base(options) { }

        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category
                {
                    Id = 1,
                    title = "Nokia",
                    displayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    title = "Apple",
                    displayOrder = 2
                },
                new Category
                {
                    Id = 3,
                    title = "Xiomi",
                    displayOrder = 3
                },
                new Category
                {
                    Id = 4,
                    title = "Oppo",
                    displayOrder = 4
                },
                new Category
                {
                    Id = 5,
                    title = "Vivo",
                    displayOrder = 5
                });
        }

    }


}
