using laba4.Model.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace laba4.Model.Database
{
	internal class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}
		public DbSet<Material> Materials { get; set; }
		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Material>().HasData(
				new Material { Id = 1, Name = "Wood" },
				new Material { Id = 2, Name = "Stone" },
				new Material { Id = 3, Name = "Rubber" },
				new Material { Id = 4, Name = "Glass" },
				new Material { Id = 5, Name = "Plastic" });

			modelBuilder.Entity<Product>().HasData(
				new Product { Id = 1, Name = "Cтол письменный для школьников", Price = 8669, MaterialId = 1 },
				new Product { Id = 2, Name = "Часы настенные интерьерные для кухни с цифрами круглые", Price = 4788, MaterialId = 1 },
				new Product { Id = 3, Name = "Массажерный коврик для ванной", Price = 564, MaterialId = 2 },
				new Product { Id = 4, Name = "Поднос декоративный на кухню", Price = 2660, MaterialId = 2 },
				new Product { Id = 5, Name = "Утка игрушка для собакt", Price = 234, MaterialId = 3 },
				new Product { Id = 6, Name = "Сапоги короткие на шнуровке", Price = 1669, MaterialId = 3 },
				new Product { Id = 7, Name = "Защитное стекло на iphone 13", Price = 185, MaterialId = 4 },
				new Product { Id = 8, Name = "Заварочный чайник «Бочонок»", Price = 409, MaterialId = 4 },
				new Product { Id = 9, Name = "Набор коробок для хранения", Price = 518, MaterialId = 5 },
				new Product { Id = 10, Name = "Конструктор с шуруповёртом", Price = 1264, MaterialId = 5 });
		}
	}
}
