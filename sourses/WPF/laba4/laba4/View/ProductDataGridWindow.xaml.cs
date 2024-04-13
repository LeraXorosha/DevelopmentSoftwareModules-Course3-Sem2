using laba4.Services.Implementations;
using laba4.Services.Interfaces;
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
	/// Логика взаимодействия для ProductDataGridWindow.xaml
	/// </summary>
	public partial class ProductDataGridWindow : Window
	{
		public event EventHandler SaveBtnClicked = null!;

		public ProductDataGridWindow(IDbWorker dbWorker)
		{
			InitializeComponent();
		}

		private void btn_save_product(object sender, RoutedEventArgs e)
		{
			SaveBtnClicked?.Invoke(this, EventArgs.Empty);
		}
    }
}
