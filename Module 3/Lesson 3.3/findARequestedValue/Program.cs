using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findARequestedValue
{
	class Program
	{
			static int SearchValue(int[] a, int val)
			{
				int i;
				for (i = 0; i < a.Length; i++)
				{
					if (a[i] == val) return i;
				}
				return -1;
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
				int val, n, found;
				Random r = new Random((int)DateTime.Now.Ticks);
				Console.WriteLine("Enter Array Size: ");
				n = int.Parse(Console.ReadLine());
				a = new int[n];
				for (int i = 0; i < n; i++)
				{
					a[i] = r.Next(1, 1000);
				}
				Console.Write("Elements of the array: ");
				ShowArray(a);
				Console.WriteLine("\nEnter a search value: ");
				val = int.Parse(Console.ReadLine());
				found = SearchValue(a, val);
				if (found != -1)
				{
					Console.Write("The search value was found at index position: " + found + ".");
				}
				else
				{
					Console.Write("The search value was not found.");
				}
				Console.Read();
			}	
		
	}
}
