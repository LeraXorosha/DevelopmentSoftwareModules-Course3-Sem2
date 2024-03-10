using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Database.Entity
{
	class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price {  get; set; }
		public int MaterialId { get; set; }
	}
}
