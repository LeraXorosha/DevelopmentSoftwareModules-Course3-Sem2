using laba4.Model.Database.Entity;
using laba4.Services.Implementations;
using laba4.Services.Interfaces;
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
	/// Логика взаимодействия для MaterialDataGridWindow.xaml
	/// </summary>

	class Me
	{
		object _me;

		Me()
		{
			_me = new Me();
		}
	}

	public partial class MaterialDataGridWindow : Window
	{
		private readonly IDbWorker _dbWorker;

		public MaterialDataGridWindow(IDbWorker dbWorker)
		{
			InitializeComponent();
			this.DataContext = dbWorker.Materials;
		}

		private void btn_save_materials(object sender, RoutedEventArgs e)
		{

		}
	}
}
