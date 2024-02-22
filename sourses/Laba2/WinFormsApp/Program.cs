using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using WinFormsApp.Forms;
using WinFormsApp.Services.Implementations;
using WinFormsApp.Services.Interfaces;
using WinFormsApp.Database;

namespace WinFormsApp
{
	internal static class Program
	{

		private static IServiceProvider _serviceProvider = null!;
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			var services = new ServiceCollection();
			services.AddTransient<MainForm>();
			services.AddTransient<LoginDialog>();
			services.AddTransient<RegisterDialog>();
			services.AddScoped<IDbWorker, DbWorker>();
			services.AddDbContext<ShopDBContext>(options => options.UseSqlite("Data source=./shop.db"));
			_serviceProvider = services.BuildServiceProvider();


			ApplicationConfiguration.Initialize();
			Application.Run(_serviceProvider.GetRequiredService <MainForm>());

		}
	}
}