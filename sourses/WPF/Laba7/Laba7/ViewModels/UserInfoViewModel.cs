using Laba7.Models;
using Laba7.Services.Implementations;
using Laba7.Services.Interfaces;
using Laba7.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Laba7.ViewModels
{
	public class UserInfoViewModel
	{
		private readonly IDbWorker _dbWorker;
		private readonly IAuthorizationService _authorizationService;
		private readonly IViewsManager _viewsManager;

		public UserInfoViewModel(IAuthorizationService authorizationService, IViewsManager viewsManager, IDbWorker dbWorker)
		{
			_dbWorker = dbWorker;
			_authorizationService = authorizationService;
			_viewsManager = viewsManager;

			SignOutCommand = new RelayCommand(SignOut);
			OpenUsersListCommand = new RelayCommand(OpenUsersList);

			Login = _authorizationService.CurrentUser.Login;
			RoleName = _authorizationService.CurrentUser.Role.Name;
		}

		public string Login { get; }
		public string RoleName { get; }

		public ICommand SignOutCommand { get; }
		public ICommand OpenUsersListCommand { get; }

		private void SignOut(object? parameter)
		{
			_authorizationService.LogOut();
			_viewsManager.Open<LogInView>(new LogInViewModel(_dbWorker, _authorizationService, _viewsManager));
		}

		private void OpenUsersList(object? parameter)
		{
			_viewsManager.Open<UsersListView>(new UsersListViewModel(_authorizationService, _viewsManager, _dbWorker));
		}

	}
}
