using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationFromBook
{
	public class Person
	{
		private string name = null;
		private string prof = null;
		private int age;


		public void SetName(string name)
		{
			this.name = name;
		}
		public void SetProfession(string prof)
		{
			this.prof = prof;
		}

		public void SetAge(int age)
		{
			this.age = age;
		}
		public void ShowInformation()
		{
			Console.WriteLine("Hi {0}! You are a {1} and {2} years old.", name, prof, age);
		}
	}
	class TestPerson
	{
		static void Main()
		{
			//Instantiating
			Person david = new Person();
			//Calling a public member method to set a name
			david.SetName("David Beckham");
			//Calling a public member method to set profession
			david.SetProfession("Football Player");
			//Calling a public member method to set age
			david.SetAge(32);
			//Calling a public member method to get the person's information
			david.ShowInformation();
			Console.Read();
		}
	}
}
