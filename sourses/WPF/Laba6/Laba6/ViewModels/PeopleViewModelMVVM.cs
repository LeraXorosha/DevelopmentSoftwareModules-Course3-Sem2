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
		private int _percentDone = 0;
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

		public int PercentDone 
		{ 
			get => _percentDone;
			set
			{ 
				if (_percentDone != value)
				{
					_percentDone = value;
					OnPropertyChanged();
				}
			}
		}

		private Task? _process = null;
		private bool stopTask = false;

		public void BeginProcess()
		{
			if (_process is not null) return;

			stopTask = false;
			_process = Task.Run(BGProcess);
		}
		void BGProcess()
		{
			try
			{
				while (PercentDone < 100)
				{
					if (stopTask) throw new Exception();
					PercentDone++;
					Thread.Sleep(100);
				}
			}
			catch (Exception) { }
		}

		public void ResetProcess()
		{
			stopTask = true;
			_process?.Wait();
			_process = null;
			PercentDone = 0;
		}


		public PeopleViewModelMVVM()
		{
			People =
			[
				new() { Id = 1, Name = "Valeria", Description="Student", DateBorn=new DateTime(2005,02,26)},
				new() { Id = 2, Name = "Vanya", Description="Student", DateBorn=new DateTime(2001,06,07)},
				new() { Id = 3, Name = "Max", Description="Student", DateBorn=new DateTime(2007,11,24)},
				new() { Id = 4, Name = "Anastasia", Description="Teacher", DateBorn=new DateTime(1987,02,06)},
				new() { Id = 5, Name = "Elena", Description="Couch", DateBorn=new DateTime(1974,04,13)},
			];
			if (People.Count > 0) ChosenPerson = People[0];
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
