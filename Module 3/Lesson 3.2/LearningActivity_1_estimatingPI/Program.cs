using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity_1_estimatingPI
{
    class Program
    {
        static double CalculatePI(double n)
        {
            double i;
            double denom = 1;
            double sign = 1;
            double sum = 0;
            for (i = 1; i <= n; i++)
            {
                sum=sum + (double)sign * 1 / denom;
                Console.WriteLine(4 * sum);
                
                sign = sign * (-1);
                denom = denom + 2;
            }
            return sum * 4;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms: ");
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(CalculatePI(n));
            }

        }
    }
}
