using Laba7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Laba7.Services
{
	public interface IDbWorker
	{
		IEnumerable<UserModel> GetUsers();
	}
}
