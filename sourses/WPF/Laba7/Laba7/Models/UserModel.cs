using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Models
{
    public class UserModel
    {
		public int Id { get; set; }
		public string Login { get; set; } = null!;
		public string RoleName { get; set; } = null!;
	}
}
