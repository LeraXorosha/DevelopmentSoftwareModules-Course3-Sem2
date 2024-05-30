using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Models.Entity
{
	public class User
	{
		public string Id { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public List<Role> Roles { get; set; }
	}
}
