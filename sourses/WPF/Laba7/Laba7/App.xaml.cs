using Laba7.Services;
using Laba7.ViewModels;
using Laba7.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Data;
using System.Windows;
using Laba7.Models.DataBase;
using Laba7.Services.Implementations;
using Laba7.Services.Interfaces;

namespace Laba7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
	{
		private void ConfigureServices(IServiceCollection services)
		{
			services.AddTransient<LogInView>();
			services.AddTransient<SignInView>();
			services.AddTransient<UserInfoView>();
			services.AddTransient<UsersListView>();

			services.AddTransient<LogInViewModel>();
			services.AddTransient<SignInViewModel>();
			services.AddTransient<UserInfoViewModel>();
			services.AddTransient<UsersListViewModel>();

			services.AddSingleton<IAuthorizationService, AuthorizationService>();
			services.AddSingleton<IDbWorker, DbWorker>();
			services.AddSingleton<IViewsManager, ViewsManager>();

			services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data source=./laba7.db"));

		}
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			var serviceCollection = new ServiceCollection();
			ConfigureServices(serviceCollection);
			var serviceProvider = serviceCollection.BuildServiceProvider();
			var MinWindow = serviceProvider.GetRequiredService<LogInView>();
			MinWindow.DataContext = serviceProvider.GetRequiredService<LogInViewModel>();
			MinWindow.Show();
		}
	}



}
