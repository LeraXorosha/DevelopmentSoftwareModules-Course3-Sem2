using Laba6.Services.Implementations;
using Laba6.Services.Interfaces;
using Laba6.ViewModels;
using Laba6.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Data;
using System.Windows;


namespace Laba6
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private readonly IServiceProvider _serviceProvider;

		public App()
		{
			var services = new ServiceCollection();
			services.AddTransient<PeopleView>();
			_serviceProvider = services.BuildServiceProvider();
		}
				
		protected override void OnStartup(StartupEventArgs e)
		{
			//PeopleView view = _serviceProvider.GetRequiredService<PeopleView>();
			//view.DataContext = new PeopleViewModelSimple();
			//view.Show();
			PeopleView view = _serviceProvider.GetRequiredService<PeopleView>();
			view.DataContext = new PeopleViewModelMVVM();
			view.Show();
		}
	}

}
