using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Database.Entity;

namespace WinFormsApp.Services.Interfaces
{

	public enum LoginErrors
	{
		Unknown,
		Success,
		PasswordIncorrect,
		LoginIncorrect
	}
	public interface IDbWorker
	{
		public bool IsUserAlreadyExists(string Login);
		public void AddUser(string Login, string password);
		public LoginErrors Auntificate(string Login, string password);
	}
}
