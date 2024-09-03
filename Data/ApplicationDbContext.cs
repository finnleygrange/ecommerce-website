using ECommerceWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceWebsite.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
					new Product
					{
						Id = 1,
						Name = "Laptop",
						Description = "A high-performance laptop with 16GB RAM and 512GB SSD.",
						Price = 999.99m,
						Quantity = 10
					},
					new Product
					{
						Id = 2,
						Name = "Smartphone",
						Description = "A latest model smartphone with a 6.5-inch display and 128GB storage.",
						Price = 699.99m,
						Quantity = 25
					},
					new Product
					{
						Id = 3,
						Name = "Wireless Headphones",
						Description = "Noise-cancelling wireless headphones with up to 20 hours of battery life.",
						Price = 149.99m,
						Quantity = 50
					}
				);
		}
	}
}
