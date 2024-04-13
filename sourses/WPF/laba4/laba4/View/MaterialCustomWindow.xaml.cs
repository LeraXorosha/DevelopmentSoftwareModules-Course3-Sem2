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
using laba4.Model.Database.Entity;
using laba4.ViewModels;
using laba4.UserControls;

namespace laba4.View
{
	/// <summary>
	/// Логика взаимодействия для MaterialCustomWindow.xaml
	/// </summary>
	public partial class MaterialCustomWindow : Window
	{

		public event EventHandler SaveBtnClicked = null!;
		public event EventHandler<Material> OpenMaterialProducts = null!;

		public MaterialCustomWindow()
		{
			InitializeComponent();

		}

		private void btn_save_custom_materials(object sender, RoutedEventArgs e)
		{
			SaveBtnClicked?.Invoke(this, EventArgs.Empty);
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			if (DataContext is not MaterialsViewModel vm) return;

			foreach(var material in vm.Materials)
			{
				var newUserControl = new MaterialControl(material);
				newUserControl.OpenMaterialProducts += NewUserControl_OpenMaterialProducts;
				stckPnlMaterials.Children.Add(newUserControl);
			}
			
		}

		private void NewUserControl_OpenMaterialProducts(object? sender, Material e)
		{
			OpenMaterialProducts?.Invoke(sender, e);
		}
	}
}
