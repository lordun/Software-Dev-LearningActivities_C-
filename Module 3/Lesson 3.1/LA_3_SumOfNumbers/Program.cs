using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_3_SumOfNumbers
{
	class Program
	{
		static int TakeValidInput()
		{
			int n;
			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("Incorrect input, please try again");
			}
			return n;
		}
		static char TakeYNInput()
		{
			char c;
			while (!char.TryParse(Console.ReadLine(), out c) || !( c=='y' || c == 'Y' || c == 'n' || c == 'N'))
			{
				Console.WriteLine("Incorrect input, please try again");
			}
			return c;

		}
		static void Main(string[] args)
		{
				int number;
				int sum;
				char c;

			do
			{
				sum = 0;
				Console.Clear();
				do
				{
					Console.WriteLine("Please enter an integer: ");
					number = TakeValidInput();
					sum = sum + number;

				} while(number!=0);

					Console.WriteLine("The sum of the integers is: "+sum);
			 
					Console.Write("\nDo you want to calculate another sum? (y/n): ");
					c = TakeYNInput();

			}	while (c == 'y' || c == 'Y');

			Console.Read();
			
		}	
	} 
}
