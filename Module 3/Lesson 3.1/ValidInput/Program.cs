using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input! Please try again:");
            }

            Console.WriteLine("You have entered: " + n);
            Console.Read();
        }
    }
}
