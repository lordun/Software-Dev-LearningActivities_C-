using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOpMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            int z = 12;
            int max = (x > y ? x : y) > z?(x > y? x: y):z;
            Console.WriteLine(max);
            Console.Read();
        }
    }
}
