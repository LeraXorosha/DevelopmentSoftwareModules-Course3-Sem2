using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba6.Models;

namespace Laba6.ViewModels
{
	internal class PeopleViewModelSimple
	{
		public PersonModelSimple _person = null!;
		public List<PersonModelSimple> People { get; set; }
		public PersonModelSimple ChosenPerson{ get => _person; set => _person = value; }



		public PeopleViewModelSimple()
		{
			People = new List<PersonModelSimple>
			{
				new PersonModelSimple{Id = 1, Name = "Valeria", Description="Student", DateBorn=new DateTime(2005,02,26)},
				new PersonModelSimple{Id = 2, Name = "Vanya", Description="Student", DateBorn=new DateTime(2001,06,07)},
				new PersonModelSimple{Id = 3, Name = "Max", Description="Student", DateBorn=new DateTime(2007,11,24)},
				new PersonModelSimple{Id = 4, Name = "Anastasia", Description="Teacher", DateBorn=new DateTime(1987,02,06)},
				new PersonModelSimple{Id = 5, Name = "Elena", Description="Couch", DateBorn=new DateTime(1974,04,13)},
			};
		}
	}
	
}
