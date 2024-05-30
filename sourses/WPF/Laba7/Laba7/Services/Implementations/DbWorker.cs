using Laba7.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba7.Services.Interfaces;
using System.Windows.Media.Media3D;

namespace Laba7.Services.Implementations
{
	internal class DbWorker : IDbWorker
	{
		private readonly AppDbContext _dbContext;

		public DbWorker(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<UserModel> GetUsers()
		{
			return _dbContext.Users.ToList().Select(u => new UserModel { Login = u.Login, RoleName = u.Role.Name });
		}
	}
}
