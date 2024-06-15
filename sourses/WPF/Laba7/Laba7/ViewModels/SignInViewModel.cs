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
using System.Windows;

namespace Laba7.ViewModels
{
	public class SignInViewModel : NotifyProperty
	{
		private readonly IDbWorker _dbWorker;
		private readonly IAuthorizationService _authorizationService;
		private readonly IViewsManager _viewsManager;

		public SignInViewModel(IAuthorizationService authorizationService, IViewsManager viewsManager, IDbWorker dbWorker)
		{
			_dbWorker = dbWorker;
			_authorizationService = authorizationService;
			_viewsManager = viewsManager;

			SignInCommand = new RelayCommand(SignIn);
			GeneratePasswordCommand = new RelayCommand(GeneratePassword);
			OpenLogInCommand = new RelayCommand(OpenLogIn);
		}

		private string _login;
		private string _password;
		private string _repeatPassword;
		public string Login
		{
			get => _login;
			set { _login = value; OnPropertyChanged(nameof(Login)); }
		}

		public string Password
		{
			get => _password;
			set { _password = value; OnPropertyChanged(nameof(Password)); }
		}

		public string RepeatPassword
		{
			get => _repeatPassword;
			set { _repeatPassword = value; OnPropertyChanged(nameof(RepeatPassword)); }
		}

		public ICommand SignInCommand { get; }
		public ICommand GeneratePasswordCommand { get; }
		public ICommand OpenLogInCommand { get; }

		private void SignIn(object? parameter)
		{
			if (Password != RepeatPassword)
			{
				MessageBox.Show("Пароли не совпадают");
				return;
			}

			if (_authorizationService.SignIn(Login, Password))
			{
				_viewsManager.Open<UserInfoView>(new UserInfoViewModel(_authorizationService, _viewsManager, _dbWorker));
			}
			else
			{
				MessageBox.Show("Логин уже занят");
			}
		}

		private void GeneratePassword(object? parameter)
		{
			Password = Guid.NewGuid().ToString().Substring(0, 8);
			RepeatPassword = Password;
		}

		private void OpenLogIn(object? parameter)
		{
			_viewsManager.Open<LogInView>(new LogInViewModel(_dbWorker, _authorizationService, _viewsManager));
		}
	}
}

