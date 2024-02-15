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
        private static string _connectionString = "Data sourse=./Shop.db";
        public DbSet<User> Users { get; set; }

        protected ShopDBContext()
        {
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlite(connectionString: _connectionString);
		}

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
