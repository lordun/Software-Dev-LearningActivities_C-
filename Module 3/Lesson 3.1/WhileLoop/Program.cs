using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countup = 1;
            while (countup <= 10)
            {
                Console.WriteLine(countup*5);
                ++countup;
            }

            Console.Read();
        }
    }
}
