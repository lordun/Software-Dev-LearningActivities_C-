using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity3_PrintingNumberPyramids
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;            
            int n;

            Console.WriteLine("Please enter the number of lines: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n-i; j++)
                {
                    Console.Write("  ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                for (j = 1; j <= i - 1; j++)
                {
                    Console.Write(i - 1 * j + " ");
                }

                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
