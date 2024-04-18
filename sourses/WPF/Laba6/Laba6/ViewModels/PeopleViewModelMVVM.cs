using Laba6.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.ViewModels
{
	internal class PeopleViewModelMVVM : INotifyPropertyChanged
	{

		public PersonModelMVVM _person = null!;
		public ObservableCollection<PersonModelMVVM> People {get; set;}
		public PersonModelMVVM ChosenPerson { 
			get => _person;
			set 
			{ 
				if (_person != value)
				{
					_person = value;
					OnPropertyChanged();
				}
			}  
		}


		public PeopleViewModelMVVM()
		{
			People = new ObservableCollection<PersonModelMVVM>
			{
				new PersonModelMVVM{ Id = 1, Name = "Valeria", Description="Student", DateBorn=new DateTime(2005,02,26)},
				new PersonModelMVVM{ Id = 2, Name = "Vanya", Description="Student", DateBorn=new DateTime(2001,06,07)},
				new PersonModelMVVM{ Id = 3, Name = "Max", Description="Student", DateBorn=new DateTime(2007,11,24)},
				new PersonModelMVVM{ Id = 4, Name = "Anastasia", Description="Teacher", DateBorn=new DateTime(1987,02,06)},
				new PersonModelMVVM { Id = 5, Name = "Elena", Description="Couch", DateBorn=new DateTime(1974,04,13)},
			};
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}
