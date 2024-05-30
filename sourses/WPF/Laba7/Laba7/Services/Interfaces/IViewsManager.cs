using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba7.Services.Interfaces
{
    public interface IViewsManager
    {
		public Window Current => throw new NotImplementedException();

		public void Open<TView>(object? dataContext = null) where TView : Window
		{
			throw new NotImplementedException();
		}

    }
}
