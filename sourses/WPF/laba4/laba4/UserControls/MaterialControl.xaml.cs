using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using laba4.Services.Implementations;
using laba4.Services.Interfaces;
using laba4.ViewModels;
using laba4.Model.Database.Entity;
namespace laba4.UserControls
{
	/// <summary>
	/// Логика взаимодействия для MaterialControl.xaml
	/// </summary>
	public partial class MaterialControl : UserControl
	{
		public event EventHandler<Material> OpenMaterialProducts = null!;

		private Material _material;

		public MaterialControl(Material material)
		{
			InitializeComponent();
			_material = material;
			DataContext = material;
		}

		private void ViewModel_BtnProducts_Click(object sender, RoutedEventArgs e)
		{
			OpenMaterialProducts?.Invoke(this, _material);
		}
	}
}
