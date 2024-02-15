using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Database.Entity;
using WinFormsApp.Services.Interfaces;

namespace WinFormsApp.Services.Implementations
{
	internal class DbWorker : IDbWorker
	{
		public bool AddUser(string Login, UserPassword password)
		{
			throw new NotImplementedException();
		}

		public bool Auntificate(string Login, UserPassword password)
		{
			throw new NotImplementedException();
		}

		public bool IsUserAlreadyExists(string Login)
		{
			throw new NotImplementedException();
		}
	}
}
