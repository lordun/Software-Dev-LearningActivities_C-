using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DMatricesRandomlyDisplayMultiplicationMatrix
{
    class Program
    {
        static void Populate(int[,] x)
        {
            Random r = new Random();
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = r.Next(1, 10);
                }
            }
        }
        
        static void Display(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,3}", x[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }
        static int [,] GetMatrixMultiplication(int[,] x,int[,] y)
        {
            int i, j, k;
            int[,] z = new int[x.GetLength(0), y.GetLength(1)];
            for (i = 0; i < x.GetLength(0); i++)
            {
                for (j = 0; j < y.GetLength(1); j++)
                {
                    z[i,j] = 0;

                    for (k = 0; k < x.GetLength(1); k++)
                    {
                        z[i, j] += x[i, k] * y[k, j];
                    }
                }
            }
            return z;
        }
        static void Main(string[] args)
        {
                int[,] x;
                int[,] y;
                int[,] z;
            Console.WriteLine("Enter the total rows for Matrix-01: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total columns for Matrix-01: ");
            int cCR = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total columns for Matrix-02: ");
            int c = int.Parse(Console.ReadLine());

            x = new int[r, cCR];
            y = new int[cCR, c];

            Populate(x);
            Populate(y);
            Console.WriteLine("The contents of Matrix-01: ");
            Display(x);
            Console.WriteLine("The contents of Matrix-02: ");
            Display(y);

            z= GetMatrixMultiplication(x, y);
            Console.WriteLine("The values of the multiplication matrix are: " + GetMatrixMultiplication(x, y));
            Display(z);

            Console.Read();
        }
    }
}
