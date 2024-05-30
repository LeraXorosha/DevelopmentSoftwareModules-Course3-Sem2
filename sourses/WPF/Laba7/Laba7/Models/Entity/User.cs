﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Models.Entity
{
	public class User
	{
		public int Id { get; set; }
		public string Login { get; set; } = null!;
		public string Password { get; set; } = null!;
		public int RoleId { get; set; }
		public List<Role> Roles { get; set; }
	}
}
