using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingByDefaultArguments
{
	public class Summation
	{
		private void ShowMessage(int n)
		{
			Console.Write("The Summation of {0} numbers is: ", n);
		}

		public int GetSummation(int a, int b, int c = 0, int d = 0)
		{
			if (c == 0)
			{
				ShowMessage(2);
				return a + b;
			}
			else if (d == 0)
			{
				ShowMessage(3);
				return a + b + c;
			}
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
