using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Models.DataBase.Entity
{
    public class User : NotifyProperty
    {
		private int _id;
		private string _login = null!;
		private string _password = null!;
		private int _roleId { get; set;}
		public Role Role { get; set; } = null!;

		public int Id
		{
			get => _id;
			set
			{
				if (_id != value)
				{
					_id = value;
					OnPropertyChanged();
				}
			}
		}

		public string Login
		{
			get => _login;
			set
			{
				if (_login != value)
				{
					_login = value;
					OnPropertyChanged();
				}
			}
		}

		public string Password
		{
			get => _password;
			set
			{
				if (_password != value)
				{
					_password = value;
					OnPropertyChanged();
				}
			}
		}

		public int RoleId
		{
			get => _roleId;
			set
			{
				if (_roleId != value)
				{
					_roleId = value;
					OnPropertyChanged();
				}
			}
		}
	}
}
