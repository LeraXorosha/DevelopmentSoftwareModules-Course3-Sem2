using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Models.DataBase.Entity
{
    public class Role
    {
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;

		public virtual IEnumerable<User> Users { get; set; }

	}
}
