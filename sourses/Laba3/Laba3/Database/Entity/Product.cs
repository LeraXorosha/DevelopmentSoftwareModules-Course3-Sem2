using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


		[ForeignKey("MaterialId")]
		public int MaterialId { get; set; }
		//public virtual Material Material { get; set; }
	}
}
