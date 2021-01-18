using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findSummationOfFirstMiddleandLastArray
{
	class Program
	{
		static double CalculateSumFirstMiddleLast(int[] a)
		{
			int i;
			double sum;
			sum = a[0] + a[a.Length - 1];
			if (a.Length % 2 == 0)
			{
				sum += (a[(a.Length - 1) / 2] + a[a.Length / 2]) / 2.0;
			}
			else
			{
				sum += a[a.Length / 2];
			}
			return sum;
		}
		static void ShowArray(int[] a)
		{
			int i;
			for (i = 0; i < a.Length; i++)
			{
				if (i % 30 == 0) Console.WriteLine();
				Console.Write(a[i] + " ");
			}
		}
		public static void Main()
		{
			int[] a;
			Random r = new Random((int)DateTime.Now.Ticks);
			Console.WriteLine("Enter Array Size: ");
			int n = int.Parse(Console.ReadLine());
			a = new int[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = r.Next(1, 10);
			}
			Console.Write("Elements of the array: ");
			ShowArray(a);
			Console.Write("\nThe summation of the First, Middle, and Last positions' value is: " + CalculateSumFirstMiddleLast(a));
			Console.Read();
		}
	}
}
