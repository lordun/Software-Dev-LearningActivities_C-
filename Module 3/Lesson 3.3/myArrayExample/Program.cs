using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //One Dimensional
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i + 1;
                Console.WriteLine("Value at index " + i + " is: " + myArray[i]);
            }
            Console.WriteLine();
            
            //Two Dimensional
            int[,] myArray1 = new int[3, 4];
            for (int i = 0; i < myArray1.GetLength(0); i++)
            {
                for (int j = 0; j < myArray1.GetLength(1); j++)
                {
                    myArray1[i, j] = (int)Math.Pow(i + 1, j);
                    Console.WriteLine("Value at row= " + i + ", column= " + j + " is: " + myArray1[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
