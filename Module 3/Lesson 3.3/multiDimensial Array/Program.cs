using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiDimensial_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[,,] { { { 1, 1,10,10 }, { 2, 2, 10, 10 }, { 3, 3, 10, 10 }, { 4, 4, 10, 10 } }, { { 1, 1, 20, 20 }, { 2, 2, 20, 20 }, { 3, 3, 20, 20 }, { 4, 4, 20, 20 } } , { { 1, 1, 30, 30 }, { 2, 2, 30, 30 }, { 3, 3, 30, 30 }, { 4, 4, 30, 30 } } };
            Console.WriteLine(myArray.GetLength(0));
            Console.WriteLine(myArray.GetLength(1));
            Console.WriteLine(myArray.GetLength(2));

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(string.Format("{0,3}", myArray[i, j, k] + " "));
                    }
                }
                Console.WriteLine();
            }         
        }
    }
}
