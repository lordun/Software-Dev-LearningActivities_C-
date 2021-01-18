using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity6_DistanceBetweenPoints
{
    class Program
    {
		static double DistanceOriginPointA(float x1, float x3, float y1, float y3, float z1, float z3)
		{
			return Math.Sqrt(((x3 - x1) * (x3 - x1) + ((y3 - y1) * (y3 - y1)) + ((z3 - z1) * (z3 - z1))));
		}
		static double DistanceOriginPointB(float x3, float x2, float y3, float y2, float z3, float z2)
		{
			return Math.Sqrt(((x2 - x3) * (x2 - x3) + ((y2 - y3) * (y2 - y3)) + ((z2 - z3) * (z2 - z3))));
		}
		static double DistanceBetweenPoints(float x1, float x2, float y1, float y2, float z1, float z2)
		{
			return Math.Sqrt(((x2 - x1) * (x2 - x1) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1))));
		}
		
		static void Main(string[] args)
		{
			float x1, x2, y1, y2, z1, z2;
			float x3 = 0;
			float y3 = 0;
			float z3 = 0;

			Console.WriteLine("Enter the x coordinate for Point A ");
			x1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the y coordinate for Point A ");
			y1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the y coordinate for Point A ");
			z1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the x coordinate for Point B ");
			x2 = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the y coordinate for Point B ");
			y2 = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the y coordinate for Point B ");
			z2 = float.Parse(Console.ReadLine());


			Console.WriteLine("The distance between the origin and Point A is " + DistanceOriginPointA(x1, x3, y1, y3, z1, z3));
			Console.WriteLine("The distance between the origin and Point B is " + DistanceOriginPointB(x3, x2, y3, y2, z3, z2));
			Console.WriteLine("The distance between the Point A and Point B is " + DistanceBetweenPoints(x1, x2, y1, y2, z1, z2));
			Console.ReadLine();
		
		}
	}
}

