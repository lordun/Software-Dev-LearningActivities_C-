using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA2_QuadEquations_Video
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, discriminant;
            float root1, root2;
            
            Console.WriteLine("Enter value a= ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value b= ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value c= ");
            c = int.Parse(Console.ReadLine());

            discriminant = (b * b) - (4 * a * c);

            if(discriminant<0)
            {
                Console.WriteLine("There are no real roots");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("There is one real root");
                root1 = ((float)(-1) * b) / (2 * a);
                Console.WriteLine("The only real root is: " + root1);
            }
            else
            {
                Console.WriteLine("There are two real roots");
                root1 = (((-1) * b) + ((float)Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
                root2 = (((-1) * b) - ((float)Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
                Console.WriteLine("The first real root is: " + root1);
                Console.WriteLine("The second real root is: " + root2);
            }
        }
    }
}
