using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba7.Services
{
	public interface IViewsManager
	{
		Window Current { get; }
		void Open<TView>(object? dataContext = null) where TView : Window;
	}
}
