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
		User CurrentUser { get; }
		bool LogIn(string login, string password);
		bool SignIn(string login, string password);
		void LogOut();
	}
}
