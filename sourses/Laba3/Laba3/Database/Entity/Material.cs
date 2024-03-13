using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Database.Entity
{
	public class Material
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual IEnumerable<Product> Products { get; set; }
	}
}
