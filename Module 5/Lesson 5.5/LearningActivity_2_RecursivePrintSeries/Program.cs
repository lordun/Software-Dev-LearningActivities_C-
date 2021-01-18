using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity_2_RecursivePrintSeries //1+x+x.pow2+x.pow3+x.pow4+...x.pown=sum
{
    class Program
    {
        static int Term(int x, int n) //Calculate a term for x to the power of n
        {
            if (n == 0) return 1;
            return x * Term (x, n - 1);
        }
        static int Summation(int x, int n) //Sum of the values of all the terms together
        {
            int sum;
            if (n == -1) return 0;
            sum = Term(x, n) + Summation(x, n - 1);
            Console.Write(Term(x, n) + "+");
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\b=" + Summation(x, n));

            

            Console.Read();
        }
    }
}
