using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeofCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your radius value: ");
            int r = int.Parse(Console.ReadLine());

            const float pi = 3.141592654f;
            float circum = 2 * pi * r;
            float area = pi * r * r;
            Console.WriteLine("The circumference of the circle is: " + circum);
            Console.WriteLine("The area of the circle is: " + area);

        }
    }
}
