using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity4_SumOfASeries
{
    class Program
    {
        static int Factorial(int x)
        {
            int fact = 1;
            while (x > 1)
            {
                fact = fact * x;
                x--;
            }
            return fact;
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value of x: ");
            int x = int.Parse(Console.ReadLine());

            double denom=1;
            double numer=1;
            double sign=1;
            double add = 0;
            double product;
            int i;

            for (i = 1; i <= n; i++)
            {

                denom = Factorial(2*i-1);
                numer = Math.Pow(x, 2 * i - 1);
                sign = i % 2 == 0 ? -1 : 1;

                product = numer * sign / denom;

                add = add + product;

                //Console.WriteLine(denom);
                //Console.WriteLine(numer);
                //Console.WriteLine(sign);

                if (sign > 0)
                {
                    Console.Write(String.Format(" + {0:0.00}", (product)));
                }
                else
                {
                    Console.Write(String.Format(" {0:0.00}", (product)));
                }
            }
            
            Console.Write(String.Format(" = {0:0.00}", (add)));
            Console.Read();
        }
    }
}
