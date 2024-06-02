using System;
using Microsoft.EntityFrameworkCore;
namespace AspNetCoreWebApi.Models
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Men"},
				new Category { Id = 2, Name = "Female"},
				new Category { Id = 3, Name = "UniSex"}
				);
			modelBuilder.Entity<Product>().HasData(
				new Product { Id = 1, Name = "Camo Block Oversize Tee ", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 1 },
                new Product { Id = 2, Name = "Polo T-Shirt", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 1 },
                new Product { Id = 3, Name = "Day to Day Jogger", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 1 },
                new Product { Id = 4, Name = "Premium Tempo Tracks", Description = "Classy,Timeless", Price = 99.99, IsAvailable = false, CatId = 1 },
                new Product { Id = 5, Name = "Flex Long Sleeve Crop", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 2 },
                new Product { Id = 6, Name = "Women's Relaxed Fit Short", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 2 },
                new Product { Id = 7, Name = "Slogan Oversized Crop", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 2 },
                new Product { Id = 8, Name = "Ruched Halter Top", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 2 },
                new Product { Id = 9, Name = "Everyday Legging", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 2 },
                new Product { Id = 10, Name = "Varsity Supersize Tee", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 3 },
                new Product { Id = 11, Name = "Lounge Track Hoodie", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 3 },
                new Product { Id = 12, Name = "Bucket Hat", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 3 },
                new Product { Id = 13, Name = "Classic Slide", Description = "Classy,Timeless", Price = 99.99, IsAvailable = true, CatId = 3 }

                );
		}
	}
}

