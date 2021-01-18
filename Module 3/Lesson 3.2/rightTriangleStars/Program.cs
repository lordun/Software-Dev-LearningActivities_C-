using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightTriangleStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            n = 10;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.Read();
         }
    }
}
