using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClassPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 15;
            

            for (i = 0; i <= n; i++)
            {
                
                Console.Write(i%5+1 +" ");
            }
            Console.Write("\b\b");
        }
    }
}
