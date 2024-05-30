using Laba7.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Services
{
	public interface IAuthorizationService
	{
		void LogIn(string login, string password);
		void SignIn(string login, string password);
		void LogOut();
		User CurrentUser { get; }
	}
}
