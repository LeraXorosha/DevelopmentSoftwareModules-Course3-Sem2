using laba4.Services.Implementations;
using laba4.Services.Interfaces;
using laba4.View;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba4
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly IServiceProvider _serviceProvider;
		public MainWindow(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void btn_open_materials(object sender, RoutedEventArgs e)
		{
			MaterialDataGridWindow materialsGrid = _serviceProvider.GetRequiredService<MaterialDataGridWindow>();
			materialsGrid.Show();
		}

		private void btn_open_custom_materials(object sender, RoutedEventArgs e)
		{

		}

		private void btn_open_custom_products(object sender, RoutedEventArgs e)
		{

		}

		private void btn_open_products(object sender, RoutedEventArgs e)
		{

		}
	}
}