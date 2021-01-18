using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActvity2_PrintingPyramids
{
    class Program
    {

        static void Main(string[] args)
        {
            int i;
            int j;
            int k;
            int n;

            Console.WriteLine("Please enter the number of lines: ");
            n = int.Parse(Console.ReadLine());

            for (j = 1; j <= n; j++)
            {
                for (k = 1; k <= n - j; k++)
                {
                    Console.Write("  ");
                }
                for (i = 1; i <= j; i++)
                {                         
                    Console.Write("{0,4}", "*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
           
        
    }
}
