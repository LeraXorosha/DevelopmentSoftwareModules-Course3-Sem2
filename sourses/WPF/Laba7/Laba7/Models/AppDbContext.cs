using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Laba7.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Laba7.Models
{ 
	internal class AppDbContext : DbContext

	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(
				new User { Id = 1, Login = "admin", Password = "admin", RoleId = 1 },
				new User { Id = 2, Login = "user", Password = "user", RoleId = 2 }
				);

			modelBuilder.Entity<Role>().HasData(
				new Role { Id = 1, Name = "Admin"  },
				new Role { Id = 2, Name = "User" }
				);
		}

	}
}
