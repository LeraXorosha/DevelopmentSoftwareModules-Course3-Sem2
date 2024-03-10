using Laba3.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Laba3.Database;
using Laba3.Services.Implementations;


namespace Laba3
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
			var services = new ServiceCollection();
			services.AddTransient<MainForm>();
			services.AddTransient<MaterialsDataGridForm>();
			services.AddTransient<ProductsDataGridForm>();
			services.AddScoped<IDbWorker, DbWorker>();
			services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data source=./app.db"));
			_serviceProvider = services.BuildServiceProvider();


			ApplicationConfiguration.Initialize();
			Application.Run(_serviceProvider.GetRequiredService<MainForm>());

		}
	}
}