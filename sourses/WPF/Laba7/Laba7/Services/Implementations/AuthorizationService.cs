using Laba7.Models.DataBase;
using Laba7.Models.DataBase.Entity;
using Laba7.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba7.Services.Interfaces;
using Laba7.Models.DataBase;
using Laba7.Models.DataBase.Entity;
using System.Data.Entity;


namespace Laba7.Services.Implementations
{
	internal class AuthorizationService  : IAuthorizationService
	{
		private readonly AppDbContext _dbContext;
		private User? _currentUser;

		public AuthorizationService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public User CurrentUser => _currentUser ?? throw new InvalidOperationException("Ни один пользователь не вошел в систему");


		public bool LogIn(string login, string password)
		{
			var user = _dbContext.Users.Include(u => u.Role)
								  .SingleOrDefault(u => u.Login == login && u.Password == password);

			if (user is null)
			{
				throw new Exception("Неверный логин или пароль");
				return false;
			}

			_currentUser = user;
			return true;
		}

		public bool SignIn(string login, string password)
		{
			if (_dbContext.Users.Any(u => u.Login == login))
			{
				throw new Exception("Пользователь с таким логином уже существует");
				return false;
			}

			var newUser = new User { Login = login, Password = password, RoleId = 2 }; ;
			_dbContext.Users.Add(newUser);
			_currentUser = newUser;
			return true;
		}

		public void LogOut()
		{
			_currentUser = null;
		}


	}
}
