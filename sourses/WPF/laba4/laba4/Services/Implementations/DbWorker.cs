using laba4.Services.Interfaces;
using laba4.Model.Database;
using laba4.Model.Database.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Services.Implementations
{
	internal class DbWorker : IDbWorker
	{
		private readonly AppDbContext _dbContext;

		public DbWorker(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<Material> Materials => _dbContext.Materials.ToList();
		public IEnumerable<Product> Products => _dbContext.Products.ToList();
		public void SaveChanges() => _dbContext.SaveChanges();
	}
		
}
