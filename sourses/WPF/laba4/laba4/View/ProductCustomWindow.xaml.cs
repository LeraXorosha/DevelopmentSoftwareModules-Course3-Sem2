using laba4.UserControls;
using laba4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace laba4.View
{
	/// <summary>
	/// Логика взаимодействия для ProductCustomWindow.xaml
	/// </summary>
	public partial class ProductCustomWindow : Window
	{
		public event EventHandler SaveBtnClicked = null!;
		public ProductCustomWindow()
		{
			InitializeComponent();
		}

		private void btn_save_custom_products(object sender, RoutedEventArgs e)
		{
			SaveBtnClicked?.Invoke(this, EventArgs.Empty);
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			if (DataContext is not ProductsViewModel productsVM) return;

			foreach (var product in productsVM.Products)
			{
				var newuserControl = new ProductControl
				{
					DataContext = new ProductViewModel()
					{
						Product = product,
						Materials = productsVM.Materials
					},
				};
				stckPnlProducts.Children.Add(newuserControl);

			};
		}
	}
}
