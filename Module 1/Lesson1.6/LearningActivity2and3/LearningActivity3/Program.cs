using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity3
{
	class Program
	{
		public static void GreetCustomerName()
		{
			var customerName = Console.ReadLine();

			Console.WriteLine("Hi " + customerName + "!");
			Console.WriteLine("Thank you very much for shopping with us.");
			Console.WriteLine("Our shop usually keeps special offers for customers like you; " + customerName + ".");
			Console.WriteLine("So " + customerName + ", do you want to explore your offer?");
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Customer Name");

			GreetCustomerName();
		}
	}
}