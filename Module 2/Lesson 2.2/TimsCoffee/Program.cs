using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimsCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to Tim's coffee shop!");
			Console.WriteLine("Would you like to order cofee? Y/N");
			string option;
			bool coffee = false;
			option = Console.ReadLine();
			if (option == "Y" || option == "y" || option == "yes" || option == "Yes")
				coffee = true;
			Console.WriteLine("Would you like to order a donut?Y/N");
			bool donut = false;
			option = Console.ReadLine();
			if (option == "Y" || option == "y" || option == "yes" || option == "Yes")
				donut = true;
			if (coffee && donut)
				Console.WriteLine("Great choice! You ordered a combo.");
			else if (!(coffee || donut))
				Console.WriteLine("You ordered nothing.");
			else
				Console.WriteLine("Excellent! You have placed one item order!");

			Console.Read();
		}
    }
}
