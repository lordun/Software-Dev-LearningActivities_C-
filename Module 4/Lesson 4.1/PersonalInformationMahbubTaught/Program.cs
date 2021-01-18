using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationMahbubTaught
{
	public class Person
	{
		private string _name = null;
		private string _prof = null;
		private int _age;

		public string Name { get => _name; set => _name = value; }
		public string Profession { get => _prof; set => _prof = value; }
		public int Age { get => _age; set => _age = value; }

		public void ShowInformation()
		{
			Console.WriteLine("Hi {0}! You are a {1} and {2} years old.", Name, Profession, Age);
		}
	}
		class Program
		{
		static void Main()
		{
			//Instantiating
			Person david = new Person();
			//Calling a public member method to set a name
			david.Name="David Beckham";
			//Calling a public member method to set profession
			david.Profession ="Football Player";
			//Calling a public member method to set age
			david.Age=32;
			//Calling a public member method to get the person's information
			david.ShowInformation();
			Console.Read();
		}
	}
}
