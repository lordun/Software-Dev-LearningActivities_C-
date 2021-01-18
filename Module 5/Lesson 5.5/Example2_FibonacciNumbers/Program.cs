using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_FibonacciNumbers
{
    class Program
    {
        static int FiboLoop(int n)
        {
            int prev = 0;
            int cur = 1;
            int temp;
            int i = 1;

            if (n == 0) return 0;
            else if (n == 1 || n == 2) return 1;
            while (i < n)
            {
                temp = cur;
                cur = cur + prev;
                prev = temp;
                i++;
            }
            return cur;
        }

       static int FiboRecursive(int n)
        {
            if (n<=1) return n;
            return FiboRecursive(n - 1) + FiboRecursive(n - 2);
        }

       
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter a value: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("The Fibonacci numbers from the Loop are: " + FiboLoop(i));
            }

            Console.WriteLine("\nPlease enter a value: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("The Fibonacci numbers from the Recursive method are: " + FiboRecursive(i));
            }

            Console.Read();
            
        }
    }
}
