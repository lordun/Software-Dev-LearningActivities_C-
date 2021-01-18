using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 5;
            int j;

            for (j = 1; j <= n; j++)
            {
                for (i = 1; i <= j; i++)
                {
                    Console.Write("{0,4}"," " + i + " "); 
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
