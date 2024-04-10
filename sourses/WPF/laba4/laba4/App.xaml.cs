using laba4.Model.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using laba4.View;
using laba4.Services.Implementations;
using laba4.Services.Interfaces;

namespace laba4
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{		
		private void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<MainWindow>();
			services.AddSingleton<MaterialDataGridWindow>();

			services.AddScoped<IDbWorker, DbWorker>();
			services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data source=./app.db"));
		
		}
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			var serviceCollection = new ServiceCollection();
			ConfigureServices(serviceCollection);
			var serviceProvider = serviceCollection.BuildServiceProvider();
			var MinWindow = serviceProvider.GetRequiredService<MainWindow>(); ; //тут вызвать окно черз сервис провайдер
			MinWindow.Show();
		}
	}

}
