using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Laba7.Models.DataBase.Entity;
using Laba7.Services.Interfaces;

namespace Laba7.Services.Implementations
{
	internal class ViewsManager : IViewsManager
	{
		private Window? _currentWindow;

		public Window CurrentWindow => _currentWindow = null!;

		public void Open<TView>(object? dataContext = null) where TView : Window
		{
			// Закрытие текущего окна
			_currentWindow?.Close();

			// Создание нового окна
			var newWindow = Activator.CreateInstance<TView>();
			newWindow.DataContext = dataContext;

			// Открытие нового окна
			_currentWindow = newWindow;
			newWindow.Show();

		}
	}
}
