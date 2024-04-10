using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Model.Database.Entity
{
	public class Material
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual IEnumerable<Product> Products { get; set; }
	}
}
