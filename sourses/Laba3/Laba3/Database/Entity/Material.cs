using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Database.Entity
{
	class Material
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Product> Products { get; set; }
	}
}
