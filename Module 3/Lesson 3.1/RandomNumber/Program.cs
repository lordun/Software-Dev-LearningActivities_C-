using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Random r = new Random();
            int rVal = r.Next(1, 101);
            Console.Write(rVal + " ");

            /*
            while (i<10)
            {
                rVal = r.Next(1, 101);
                Console.Write(i + " ");
                i++;
            }
            */

            Console.Read();

        }
    }
}
