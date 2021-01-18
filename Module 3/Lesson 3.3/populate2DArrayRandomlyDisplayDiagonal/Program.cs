using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populate2DArrayRandomlyDisplayDiagonal
{
    class Program
    {
        static void Populate(int [,] y)
        {
            Random r = new Random();
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    y[i, j] = r.Next(0, 9);
                }
            }
        }
        static void Display(int[,] y)
        {
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,3}", y[i, j]) + " ");
                }
                Console.WriteLine ();
            }
        }
        static int FindSumDiagonal(int[,] y)
        {
            int sum = 0;
            for (int i = 0; i < y.GetLength(0); i++)
            {
                sum += y[i, i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] y;
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            

            y = new int[n, n];

            Populate(y);
            Display(y);

            Console.WriteLine("The summation of the diagoanl elements are: "+FindSumDiagonal(y));
        }
    }
}
