using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumUsingRecursiveFunction
{
    class Program
    {
        static void Print1ToN(int n)//using Loop
        {
            for (int i=1;i<=n;i++)
            {
                Console.Write(i + " ");
            }
        }
        static void RecPrint1ToN(int n)//using Recursive Function
        {
            if (n == 0) return;
            RecPrint1ToN(n - 1);
            Console.Write(n + " ");


        }
        static void Main(string[] args)
        {
            Print1ToN(100); //Using Loop
            Console.WriteLine();
            Console.WriteLine();
            RecPrint1ToN(100); //Using Recursive Function
            Console.Read();
        }
        
    }
}
