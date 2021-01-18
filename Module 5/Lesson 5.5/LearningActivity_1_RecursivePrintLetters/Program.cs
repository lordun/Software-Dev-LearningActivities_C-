using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity_1_RecursivePrintLetters
{
    class Program
    {
        static void PrintLetters(int n) //using Recursive Function
        {
            if (n == 0) return;
            PrintLetters(n - 1);
            Console.Write((char)('A'+n-1)+" ");


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of letters to print: ");
            int n = int.Parse(Console.ReadLine());
            
            PrintLetters(n);
            
            Console.Read();
        }
    }
}
