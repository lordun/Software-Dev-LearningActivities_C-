using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity5_BrokenCodeTriangles
{

	class Program
	{
		const float PI = 3.14159f;

		static float DegreesToRadians(float degrees)
		{

			return (PI / 180.0f) * degrees;
		}
		static double CalcTriangleEdge(float a, float b, float gamma)
		{
			return Math.Sqrt((a * a) + (b * b) - (2 * a * b * (Math.Cos(gamma))));
		}

			   
		static void Main(string[] args)
		{
			float a, b, gamma;
			Console.WriteLine("Enter the length side a: ");
			a = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the length of side b: ");
			b = float.Parse(Console.ReadLine()); ;
			Console.WriteLine("Enter the angle gamma: ");
			gamma = float.Parse(Console.ReadLine());

			Console.WriteLine("The length of side c is " + CalcTriangleEdge(a, b, DegreesToRadians(gamma)));
			Console.ReadLine();
			//return "0";
		}
	}
}
