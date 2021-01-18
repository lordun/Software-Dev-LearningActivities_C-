using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape2DExample
{
	public class Shape2D
	{
		public double A { set; get; }
		public double B { set; get; }
		public static int Count { get; private set; }
		public Shape2D(double a)
		{
			A = a; B = 0;
			Count++;
		}
		public Shape2D(double a, double b):this(a)
		{
			B = b;
		}
		public double GetArea()
		{
			if (B == 0) return A * A;
			else return A * B;
		}
	}
	class Program
	{
		static void Display(List<Shape2D> allObj)
		{
			int i = 0;
			foreach (var obj in allObj)
			{
				i++;
				if (obj.B == 0)
				{
					Console.WriteLine("{0}. Square object with area {1}.", i, obj.GetArea());
				}
				else
				{
					Console.WriteLine("{0}. Rectangle object with area {1}.", i, obj.GetArea());
				}
			}
		}
		static void Main(string[] args)
		{
			string input = null;
			List<Shape2D> allObjects = new List<Shape2D>();
			for(; ;) //creates an infinity loop
			{
				Console.Clear();
				Console.WriteLine("Please enter 1 for creating a sqaure object.");
				Console.WriteLine("Please enter 2 for creating a rectangle object.");
				Console.WriteLine("Please enter 3 to display the entire object list.");
				Console.WriteLine("Please enter 4 for exit.");
				input = Console.ReadLine();
				if (input == "1")
				{
					var sqr = new Shape2D(3);
					allObjects.Add(sqr);
					Console.WriteLine("Square object created...");
					Console.Read();
				}
				else if (input == "2")
				{
					var rect = new Shape2D(2, 5);
					allObjects.Add(rect);
					Console.WriteLine("Rectangle object created...");
					Console.Read();
				}
				else if (input == "3")
				{
					Display(allObjects);
					Console.Read();
				}
				else if (input == "4") break;
			}
			
			Console.WriteLine("The total objects created so far is " + Shape2D.Count);
			Console.Read();
			//var sqr = new Shape2D(3);
			//var rect = new Shape2D(2, 5);
		}
	}
}
