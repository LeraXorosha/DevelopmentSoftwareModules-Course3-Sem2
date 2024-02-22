using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Database;
using WinFormsApp.Database.Entity;
using WinFormsApp.Services.Interfaces;

namespace WinFormsApp.Services.Implementations
{
	internal class DbWorker : IDbWorker
	{
		private readonly ShopDBContext _dbContext;

		public DbWorker(ShopDBContext dbContext)
		{
			_dbContext = dbContext;
		}
		public void AddUser(string login, string password)
		{
			_dbContext.Users.Add(new()
			{
				Login = login,
				Password = password
			});
			_dbContext.SaveChanges();
		}

		public LoginErrors Auntificate(string login, string password)
		{
			try
			{
				var user = _dbContext.Users
					.Where(x => x.Login == login).SingleOrDefault();

				if (user is null) return LoginErrors.LoginIncorrect;

				if (user.Password != (UserPassword)password) return LoginErrors.PasswordIncorrect;

				return LoginErrors.Success;
			}
			catch (Exception)
			{
				return LoginErrors.Unknown;
			}
		}

		public bool IsUserAlreadyExists(string login)
		{
			return _dbContext.Users
			.Where(x => x.Login == login)
			.Any();
		}
	}
}
