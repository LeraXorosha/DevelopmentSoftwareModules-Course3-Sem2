using Laba3.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Services.Interfaces
{
	internal interface IDbWorker
	{
		public IEnumerable<Material> Materials { get; }
		public IEnumerable<Product> Products { get; }

		public void SaveChanges();
	}
}
