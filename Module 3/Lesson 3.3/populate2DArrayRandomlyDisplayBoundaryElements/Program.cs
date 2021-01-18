using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populate2DArrayRandomlyDisplayBoundaryElements
{
    class Program
    {
                static void Populate(int[,] y)
            {
                Random r = new Random();
                for (int i = 0; i < y.GetLength(0); i++)
                {
                    for (int j = 0; j < y.GetLength(1); j++)
                    {
                        y[i, j] = r.Next(1, 10);
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
                    Console.WriteLine();
                }
            }
            static int FindSumBoundary(int[,] y)
            {
                int sum = 0;

            for (int i = 0; i < y.GetLength(0); i++)
            {
                sum += y[i, 0] + y[i,y.GetLength(1)-1];
            }
            for (int j = 1; j < y.GetLength(1)-1; j++)
            {
                sum += y[0, j] + y[y.GetLength(0) - 1,j];
            }
                return sum;
            }
            static void Main(string[] args)
            {
                int[,] y;
                Console.WriteLine("Enter m: ");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter n: ");
                int n = int.Parse(Console.ReadLine());


                y = new int[m, n];

                Populate(y);
                Display(y);

                Console.WriteLine("The summation of the boundary elements are: " + FindSumBoundary(y));
            }
        
    }
}
