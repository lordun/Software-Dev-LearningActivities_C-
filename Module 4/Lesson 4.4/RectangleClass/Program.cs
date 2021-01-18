using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals
{   // Declaring a Class
	public class Rectangle
	{
		// Declaring fields
		private double _width;
		private double _height;

		public int Width { get; set; }
		public int Height { get; set; }

		// Declaring a method
		public double GetArea()
		{
			return Width * Height;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();  // here instance r of the class (called object) is created. You may think of r as a variable (object) of the class.
			r.Width = 5;                    // here, we are accessing a field of the r object
			r.Height = 4;
			Console.WriteLine(r.GetArea()); // calling GetArea() method of the object

			Console.Read();
		}
	}
}

