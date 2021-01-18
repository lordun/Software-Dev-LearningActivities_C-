using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_TheFactorialFunction
{
    class Factorial
    {
        //Factorial Version using a Loop
        public static int FactLoop(int n)
        {
            int fact = 1;
            for (int i=2; i<=n;i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        //Factorial Version using Recursion
        public static int FactRecursive(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * FactRecursive(n - 1);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter a value to calculate it's Factorial using a Loop Method: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of {0} from the Loop is: {1}", n, FactLoop(n));

           
            Console.WriteLine("Please enter a value to calculate it's Factorial using a Recursive Method: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is: {1}", n, FactRecursive(n));
           
            Console.Read();
        }
    }
}
