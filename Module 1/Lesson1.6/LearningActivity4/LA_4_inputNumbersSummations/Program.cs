using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_4_inputNumbersSummations
{
	class Program
	{
		static int Summation(int value1, int value2, int value3)
		{

			return value1 + value2 + value3;
		}
		static void Main(string[] args)
		{

			Console.WriteLine("Enter value 1: ");
			int value1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter value 2: ");
			int value2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter value 3: ");
			int value3 = int.Parse(Console.ReadLine());

			int sum = Summation(value1,value2,value3);
			Console.WriteLine(sum);
					   			 

		}
	}
}
