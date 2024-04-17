using Laba6.ViewModels;
using Microsoft.Extensions.DependencyInjection;
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
using Laba6.ViewModels;
namespace Laba6.Views
{
	/// <summary>
	/// Логика взаимодействия для PeopleView.xaml
	/// </summary>
	public partial class PeopleView : Window
	{
		private readonly IServiceProvider _serviceProvider;
		private PeopleViewModelSimple _peopleViewModel = null!;
		public PeopleView(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			_peopleViewModel = (PeopleViewModelSimple)this.DataContext;
		}

		private void Show_in_new_window(object sender, RoutedEventArgs e)
		{
			PeopleView view = _serviceProvider.GetRequiredService<PeopleView>();
			view.DataContext = new PeopleViewModelSimple();
			view.Show();
		}

		private void Push_new_Item(object sender, RoutedEventArgs e)
		{

		}



		private void Pop_last_Item(object sender, RoutedEventArgs e)
		{

		}

		private void Change_selected_Item(object sender, RoutedEventArgs e)
		{
			var person = _peopleViewModel.ChosenPerson;
			person.Id = 1;
			person.Name = "QUEEN";
			person.Description = "Number one";
			person.DateBorn = new DateTime(2024, 11, 11);
		}

	}
}
