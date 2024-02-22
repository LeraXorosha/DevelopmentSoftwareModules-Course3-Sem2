using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Database.Entity;

namespace WinFormsApp.Database
{
    internal class ShopDBContext : DbContext
    {
		public ShopDBContext(DbContextOptions options) : base(options)
		{
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(new User
			{
				ID = 1,
				Login = "lerlera",
				Password = "0123456"

			});

			modelBuilder.Entity<User>().
				Property(x => x.Password)
				.HasConversion(new ValueConverter<UserPassword, string>(val => val,val => val));
			
		}
	}
}
