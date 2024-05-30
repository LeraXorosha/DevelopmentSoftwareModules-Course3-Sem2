using Laba7.Models.DataBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba7.Services.Interfaces
{
    public interface IAuthorizationService
    {
		public User CurrentUser => throw new NotImplementedException();

		public void LogIn(string login, string password)
		{
			throw new NotImplementedException();
		}

		public void LogOut()
		{
			throw new NotImplementedException();
		}

		public void SignIn(string login, string password)
		{
			throw new NotImplementedException();
		}
	}
}
