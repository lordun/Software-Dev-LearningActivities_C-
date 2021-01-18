using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to the digital drink fountain machine!");
			Console.WriteLine("What drink would you like? \n");
			Console.WriteLine(" 1 - Pepsi");
			Console.WriteLine(" 2 - 7up");
			Console.WriteLine(" 3 - Root Beer");
			Console.WriteLine(" 4 - Water");
			int selection;
			selection = int.Parse(Console.ReadLine());

			Console.Write("Your selection is: ");
			switch (selection)
			{
				case 1:
					Console.WriteLine("Pepsi");
					break;
				case 2:
					Console.WriteLine("7up");
					break;
				case 3:
					Console.WriteLine("Root Beer");
					break;
				case 4:
					Console.WriteLine("Water");
					break;
				default:
					Console.WriteLine("Invalid selection\nPlease try again in the next run!");
					break;
			}

			Console.Write("Thank you for visiting us.");
			Console.Read();
		}
    }
}
