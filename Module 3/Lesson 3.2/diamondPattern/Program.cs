using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n=10;
            
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n-i; j++)
                {
                    Console.Write("  ");
                }
                for (j = 1; j <= 2 * i- 1; j++)
                {
                    if (j == 1 || j == 2 * i - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");                    
                }

                Console.WriteLine();               
            }
            for (i = 1; i <= n-1; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("  ");
                }
                for (j = 1; j <= 2 * (n - i) - 1; j++)
                {
                    if (j == 1 || j == 2 * (n- i) - 1)
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
