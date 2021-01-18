using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
		static int Factorial(int n)
		{
			int fact = 1;
			while (n > 1)
			{
				fact = fact * n;
				n--;
			}
			return fact;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter an integer number");
			int n;
			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("Incorrect input! Please try again:");
			}
			Console.WriteLine("Factorial of {0} is: {1}", n, Factorial(n));
			Console.Read();
		}
	}
}
