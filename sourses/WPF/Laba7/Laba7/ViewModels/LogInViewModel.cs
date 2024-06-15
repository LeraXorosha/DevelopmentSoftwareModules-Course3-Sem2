using Laba7.Models;
using Laba7.Models.DataBase;
using Laba7.Models.DataBase.Entity;
using Laba7.Services.Implementations;
using Laba7.Services.Interfaces;
using Laba7.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Laba7.ViewModels
{
	public class LogInViewModel : NotifyProperty
	{

		private readonly IDbWorker _dbWorker;
		private readonly IAuthorizationService _authorizationService;
		private readonly IViewsManager _viewsManager;

		public LogInViewModel(IDbWorker dbWorker, IAuthorizationService authorizationService, IViewsManager viewsManager)
		{
			_dbWorker = dbWorker;
			_authorizationService = authorizationService;
			_viewsManager = viewsManager;

			LoginCommand = new RelayCommand(LogIn);
			RegisterCommand = new RelayCommand(Register);
		}

		public ICommand LoginCommand { get; }
		public ICommand RegisterCommand { get; }

		private string _login = "";
		public string Login
		{
			get => _login;
			set
			{
				_login = value;
				OnPropertyChanged();
			}
		}

		private string _password = "";
		public string Password
		{
			get => _password;
			set
			{
				_password = value;
				OnPropertyChanged();
			}
		}

		private void LogIn(object parameter)
		{
			if (_authorizationService.LogIn(Login, Password))
			{
				_viewsManager.Open<UserInfoView>(new UserInfoViewModel(_authorizationService, _viewsManager, _dbWorker));
			}
			else
			{
				MessageBox.Show("Неверный логин или пароль");
			}
		}

		private void Register(object parameter)
		{
			_viewsManager.Open<SignInView>(new SignInViewModel(_authorizationService, _viewsManager, _dbWorker));
		}
	}
}
	