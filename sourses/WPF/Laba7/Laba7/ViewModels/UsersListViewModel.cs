using Laba7.Models.DataBase.Entity;
using Laba7.Models.DataBase;
using Laba7.Models;
using Laba7.Services.Implementations;
using Laba7.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba7.Views;
using System.Windows.Input;

namespace Laba7.ViewModels
{
	public class UsersListViewModel
	{
		private readonly IDbWorker _dbWorker;
		private readonly IAuthorizationService _authorizationService;
		private readonly IViewsManager _viewsManager;

		public UsersListViewModel(IAuthorizationService authorizationService, IViewsManager viewsManager, IDbWorker dbWorker)
		{
			_dbWorker = dbWorker;
			_authorizationService = authorizationService;
			_viewsManager = viewsManager;
			ReturnToUserInfoCommand = new RelayCommand(ReturnToUserInfo);

			Users = new ObservableCollection<UserModel>(_dbWorker.GetUsers());
		}

		public ObservableCollection<UserModel> Users { get; }

		public ICommand ReturnToUserInfoCommand { get; }

		private void ReturnToUserInfo(object? parameter)
		{
			_viewsManager.Open<UserInfoView>(new UserInfoViewModel(_authorizationService, _viewsManager, _dbWorker));
		}
	}
}
