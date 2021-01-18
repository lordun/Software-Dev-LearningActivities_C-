using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
	public class Summation
	{
		private void ShowMessage(int n)
		{
			Console.Write("The Summation of {0} numbers is: ", n);
		}
		public int GetSummation(int a, int b)
		{
			ShowMessage(2);
			return a + b;
		}
		public int GetSummation(int a, int b, int c)
		{
			ShowMessage(3);
			return a + b + c;
		}
		public int GetSummation(int a, int b, int c, int d)
		{
			ShowMessage(4);
			return a + b + c + d;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Summation obj = new Summation();
			Console.WriteLine(obj.GetSummation(1, 3, 5, 7));
			Console.WriteLine(obj.GetSummation(4, 5));
			Console.WriteLine(obj.GetSummation(1, 2, 3));

			Console.Read();
		}
	}
}
