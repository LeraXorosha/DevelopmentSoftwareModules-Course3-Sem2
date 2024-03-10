using Laba3.Database;
using Laba3.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Services.Implementations
{
	internal class DbWorker : IDbWorker
	{
		private readonly AppDbContext _dbContext;

		public DbWorker(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
	}
		
}
