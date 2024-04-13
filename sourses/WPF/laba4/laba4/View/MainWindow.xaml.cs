using laba4.Services.Implementations;
using laba4.Services.Interfaces;
using laba4.View;
using laba4.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
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
		private readonly IDbWorker _dbWorker;
		public MainWindow(IServiceProvider serviceProvider, IDbWorker dbWorker)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_dbWorker = dbWorker;
		}
		
		private void SaveBtnClicked_Handler(object? sender, EventArgs e)
		{
			_dbWorker.SaveChanges();
		}

		private void btn_open_materials(object sender, RoutedEventArgs e)
		{
			var vm = new MaterialsViewModel()
			{
				Materials = _dbWorker.Materials.ToList()
			};

			MaterialDataGridWindow materialsGrid = _serviceProvider.GetRequiredService<MaterialDataGridWindow>();
			materialsGrid.DataContext = vm;
			materialsGrid.SaveBtnClicked += SaveBtnClicked_Handler;
			materialsGrid.Show();
		}

		private void btn_open_products(object sender, RoutedEventArgs e)
		{
			var vm = new ProductsViewModel()
			{
				Materials = _dbWorker.Materials.ToList(),
				Products = _dbWorker.Products.ToList(),
			};

			ProductDataGridWindow productsGrid = _serviceProvider.GetRequiredService<ProductDataGridWindow>();
			productsGrid.DataContext = vm;
			productsGrid.SaveBtnClicked += SaveBtnClicked_Handler;
			productsGrid.Show();
		}

		private void btn_open_custom_materials(object sender, RoutedEventArgs e)
		{
			var vm = new MaterialsViewModel()
			{
				Materials = _dbWorker.Materials.ToList()
			};

			MaterialCustomWindow materialsCustom = _serviceProvider.GetRequiredService<MaterialCustomWindow>();
			materialsCustom.DataContext = vm;
			materialsCustom.SaveBtnClicked += SaveBtnClicked_Handler;
			materialsCustom.OpenMaterialProducts += MaterialsCustom_OpenMaterialProducts;
			materialsCustom.Show();
		}

		private void MaterialsCustom_OpenMaterialProducts(object? sender, Model.Database.Entity.Material material)
		{
			var vm = new ProductsViewModel()
			{
				Materials = _dbWorker.Materials.ToList(),
				Products = _dbWorker.Products.Where(x => x.Material == material).ToList(),
			};

			ProductDataGridWindow productsGrid = _serviceProvider.GetRequiredService<ProductDataGridWindow>();
			productsGrid.DataContext = vm;
			productsGrid.SaveBtnClicked += SaveBtnClicked_Handler;
			productsGrid.Show();
		}

		private void btn_open_custom_products(object sender, RoutedEventArgs e)
		{
			var vm = new ProductsViewModel()
			{
				Products = _dbWorker.Products.ToList(),
				Materials = _dbWorker.Materials.ToList(),
			};
			ProductCustomWindow productCustom = _serviceProvider.GetRequiredService<ProductCustomWindow>();
			productCustom.DataContext = vm;
			productCustom.SaveBtnClicked += SaveBtnClicked_Handler;
			
			productCustom.Show();
		}
	}
}