using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_ShowOnlyPrimeNumbers2DIntegerArray
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
                    x[i, j] = r.Next(1, 20);
                }
            }
        }
       
        static void Display(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,4}", x[i, j]) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void DisplayPrimeNumber(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (IsPrime(x[i, j]))
                    {
                        Console.Write(string.Format("{0,4}", x[i, j]) + " ");
                    }
                    else
                    {
                        Console.Write(string.Format("{0,4}", "   . "));
                    }
                }
                Console.WriteLine();
            }
        }
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;

            for (int i = 2; i < n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] x;
            
            Console.WriteLine("Enter the number of rows: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int c = int.Parse(Console.ReadLine());
                        
            x = new int[r, c];

            Populate(x);
            Display(x);

            Console.WriteLine("The Prime numbers are:");
            DisplayPrimeNumber(x);

            
        }
    }
}
