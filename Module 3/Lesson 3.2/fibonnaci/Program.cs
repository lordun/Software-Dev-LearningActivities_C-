using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fibonnaci index N: ");
            int n = int.Parse(Console.ReadLine());

            int cur, prev, t;
            prev = 0;
            cur = 1;
            for (int i = 1; i <=n; i++)
            {
                t = cur;
                Console.Write(cur + ", ");
                cur = cur + prev;
                prev = t;
            }
            Console.WriteLine("\b\b.");

            Console.WriteLine("The " + n + "th Fibonnaci number is: " + prev + ".");
            Console.Read();
        }
    }
}
