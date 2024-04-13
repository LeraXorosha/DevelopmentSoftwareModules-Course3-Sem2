using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba4.Model.Database.Entity;

namespace laba4.ViewModels
{
	internal class ProductsViewModel
	{
		public List<Product> Products { get; set; } = null!;
		public List<Material> Materials { get; set; } = null!;
	}

	internal class ProductViewModel
	{
		public Product Product { get; set; } = null!;
		public List<Material> Materials { get; set; } = null!;
	}
}
