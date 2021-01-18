using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity4_SummationOfASeries
{
    class Program
    {
        static int Factorial(int n)
        {
            int fact = 1;
            while (n > 1)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }
        static double CalculateSummation(int term, int x)
        {
            double item;
            long fact;
            int sign = 1;
            double sum = 0;
            double product;

            for (int i=1;i<=term;i++)
            {
                fact = Factorial(2 * i - 1);
                item = Math.Pow(x, 2 * i - 1);
                sign = i % 2 == 0 ? -1 : 1;
                product = sign * item / fact;
                sum = sum + product;
                if (sign < 0)
                {
                    Console.Write(" - ");
                }
                else
                {
                    if (i != 1)
                        Console.Write(" + ");
                }
                Console.Write(String.Format("{0:0.00}", Math.Abs(product)));
            }
            Console.Write(String.Format(" = {0:0.00}", sum));
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of terms: ");
            int term = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value of x: ");
            int x = int.Parse(Console.ReadLine());

            CalculateSummation(term, x);

            Console.Read();
            
        }
    }   
}
