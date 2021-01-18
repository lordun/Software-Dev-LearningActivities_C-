using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k;
            int n = 7;
            int c = 1;

            for (j = 1; j <= n ; j++)
            {
                for (k= 1; k <= n-j ; k++)
                {
                    Console.Write("  ");
                }
                for (i = 1; i <= j; i++)
                {
                    if (i == 1 || j == i)
                    {
                        c = 1;
                    }
                    else
                    {
                        c = c * (j - i + 1) / (i - 1);
                    }
                        Console.Write("{0,4}", c + "  ");
                    
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
