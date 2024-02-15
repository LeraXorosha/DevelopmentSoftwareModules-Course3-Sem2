using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Database.Entity;

namespace WinFormsApp.Services.Interfaces
{
	internal interface IDbWorker
	{
		public bool IsUserAlreadyExists(string Login);
		public void AddUser(string Login, UserPassword password);
		public bool Auntificate(string Login, UserPassword password);
	}
}
