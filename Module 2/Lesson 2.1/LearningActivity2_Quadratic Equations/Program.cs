using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity2_Quadratic_Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c= ");
            int c = int.Parse(Console.ReadLine());

            int discriminant = (b * b) - (4 * a * c);

            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots ");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("The equation has one real root ");
                Console.WriteLine("r= "+ discriminant);
            }
            else
            {
                Console.WriteLine("The equation has two real roots ");
                Console.WriteLine("r1= " + discriminant+" and r2= -"+ discriminant);
            }
        }
    }
}
