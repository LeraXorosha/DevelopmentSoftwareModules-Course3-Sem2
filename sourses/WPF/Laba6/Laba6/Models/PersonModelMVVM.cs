using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
	public class PersonModelMVVM : INotifyPropertyChanged
	{
		private int _id;
		private string _name;
		private string ?_description;
		private DateTime _dateBorn;

		public int Id 
		{ 
			get => _id;
			set 
			{
				if (_id != value)
				{
					_id = value;
					OnPropertyChanged();
				}
			} 
		}
		public string Name 
		{ 
			get => _name;
			set
			{ 
				if (_name != value) 
				{ 
					_name = value;
					OnPropertyChanged();
				}
			}

		}
		public string Description 
		{
			get => _description;
			set 
			{ 
				if (_description != value) 
				{
					_description = value;
					OnPropertyChanged();
				}
			}
				
		}
		public DateTime DateBorn 
		{
			get => _dateBorn;
			set 
			{ 
				if (_dateBorn != value)
				{
					_dateBorn = value;
					OnPropertyChanged();
				}
			}
		}


		public event PropertyChangedEventHandler? PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}

	}
}
