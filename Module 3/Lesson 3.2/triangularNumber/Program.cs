using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangularNumber
{
    class Program
    {
        static int TriangularNumber(int n)
        {
            int triangular = 0;
            for (int i = 1; i <= n; i++)
                triangular = triangular + i;
            return triangular;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many triangular numbers?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.Write(TriangularNumber(i) + ", ");
            }
            Console.WriteLine("\b\b.");

            Console.Read();
        }
    }
}
