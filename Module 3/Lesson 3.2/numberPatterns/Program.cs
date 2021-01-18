using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 5;
            int j;

            for (j = 1; j <=n; j++)
            {
                for (i = 1; i<=j; i++)
                {
                    if (((i + j) + 1) % 2 == 1)
                        Console.Write("*");
                    else
                        Console.Write("$");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
