using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_BusDiscount
{
    class Program
    {
		static void Main(string[] args)
		{
			int age, salary;
			string option;
						
			Console.WriteLine("Enter your age: ");
			age = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Enter your annually salary");
			salary = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Are you a city employee? Y/N");
			option = Console.ReadLine();

					if (option == "Y" || option == "y" || option == "yes" || option == "Yes")
					
					{
						Console.WriteLine("Your monthly bus pass will cost $50");
					}
					else if (age <= 5)
					{
						Console.WriteLine("Your monthly bus pass will cost $0");
					}
					else if (age > 6 && age <= 17)
					{
						Console.WriteLine("Your monthly bus pass will cost $80");
					}
					else if (age <= 18 && age > 5 && salary < 15000)
					{
						Console.WriteLine("Your monthly bus pass will cost $80");
					}
					else if (age >= 65 && salary < 30000)
					{
						Console.WriteLine("Your monthly bus pass will cost $70");
					}
					else
					{
						Console.WriteLine("Your monthly bus pass will cost $100");
					}
						Console.Read();
				
			

		}
    }
}
