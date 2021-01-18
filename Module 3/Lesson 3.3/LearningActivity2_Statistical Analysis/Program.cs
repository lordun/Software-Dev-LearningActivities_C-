using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity2_Statistical_Analysis
{
    class Program
    {
        static void Display(int [] x)
        {
            Console.WriteLine("\nThe elements of the array are: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
        static double Summation(int[] x)
        {
            double sum=0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }
        static double Mean(int[] x)
        {
            double mean = Summation(x) / 2;
            return mean;
        }
        static int Median(int[] x)
        {
            int median = x[(x.Length - 1) / 2];
            return median;
        }
        static int FindMax(int[]x)
        {
            int max = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if(max < x[i])
                {
                    max = x[i];
                }
            }
            return max;
        }
        static int Mode(int[] frequency)
        {
            int max = frequency[0];
            int maxIndex = 0;
            int i;

            for (i = 0; i < frequency.Length; i++)
            {                 
                if (max < frequency[i])
                {
                    max = frequency[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        static void Main(string[] args)
        {
            int[] x;
            
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the random number seed of the array: ");
            int seed = int.Parse(Console.ReadLine());

            Random r = new Random(seed);
            x = new int[size];

            for (int i = 0; i < size; i++)
            {
                x[i] = r.Next(1, 11);
               
            }

            Array.Sort(x);
            Display(x);

            int limits = FindMax(x)+1;
            int[] frequency = new int[limits];

            for (int i = 0; i < x.Length; i++)
            {
                frequency[x[i]]++;
            }
            
            Console.WriteLine("\n\nThe mean of the array is: " + Mean(x));
            Console.WriteLine("\nThe median of the array is: " + Median(x));
            Console.WriteLine("\nThe mode of the array is: " + Mode(frequency));








        }
    }
}
