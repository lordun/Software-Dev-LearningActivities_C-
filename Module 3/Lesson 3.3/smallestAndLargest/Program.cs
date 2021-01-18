using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallestAndLargest
{
	class Program
	{
		static int FindMaximum(int[] a)
		{
			int i, max = a[0];
			for (i = 1; i < a.Length; i++)
			{
				if (max < a[i])
				{
					max = a[i];
				}
			}
			return max;
		}
		static int FindMinimum(int[] a)
		{
			int i, min = a[0];
			for (i = 1; i < a.Length; i++)
			{
				if (min > a[i])
				{
					min = a[i];
				}
			}
			return min;
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
				a[i] = r.Next(1, 1000);
			}
			Console.Write("Elements of the array: ");
			ShowArray(a);
			Console.WriteLine("\n\nMaximum Value of the array: " + FindMaximum(a));
			Console.WriteLine("Minimum Value of the array: " + FindMinimum(a));

			Console.Read();
		}
	}
}
