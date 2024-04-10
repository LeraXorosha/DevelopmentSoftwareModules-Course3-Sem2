using laba4.Model.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Services.Interfaces
{
	public interface IDbWorker
	{
		public IEnumerable<Material> Materials { get; }
		public IEnumerable<Product> Products { get; }

		public void SaveChanges();
	}
}
