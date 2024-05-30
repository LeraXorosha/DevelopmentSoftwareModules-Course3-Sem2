using Laba7.Views;
using System;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Laba7
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			LoginWindow loginWindow = new LoginWindow();
			loginWindow.Show();
		}
	}



}
