using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area of Triangle using Heron's Formula

            double s, area;
            double a, b, c;

            Console.WriteLine("Enter side 1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 3");
            c = double.Parse(Console.ReadLine());

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Area = {0}", area);








        }
    }
}
