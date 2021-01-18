using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_1_estimatingPI
{
    class Program
    {
        static void Main(string[] args)
        {
            double denom = 3;
            double PI = 4;
            double c = 3;

            while (denom <= 10000000)
            {
                if (c % 2 != 0)
                {
                    PI -= (4) / denom;
                    c++;
                }
                else
                {
                    PI += (4) / denom;
                    c++;

                }

                Console.WriteLine(PI);
                denom += 2;
            }
            Console.Read();
        }
    }
}
