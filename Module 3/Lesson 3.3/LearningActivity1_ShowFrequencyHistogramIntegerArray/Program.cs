using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_ShowFrequencyHistogramIntegerArray
{
    class Program
    {
        static void DisplayHistogram(int[] histogram)
        {
            for (int i = 0; i < histogram.Length; i++)
            {
                for (int j = 0; j < histogram[i]; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Display(int[]x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] x;
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the random number seed: ");
            int seed = int.Parse(Console.ReadLine());

            Random r = new Random(seed);
            x = new int[size];

            for (int i = 0; i < size; i++)
            {
                x[i] = r.Next(0, 5);
            }
            Array.Sort(x);
            Display(x);            
                        
            int[] histogram = new int[5];

            for (int i = 0; i < size; i++)
            
                histogram[x[i]]++;               
            
            for (int i = 0; i < histogram.Length; i++)
            {
                for (int j = 0; j < histogram[i]; j++)
                {
                    
                }
                Console.WriteLine("\nThe frequency of: " + i + " is: " + histogram[i]); ;
                Console.WriteLine();
            }
            
            DisplayHistogram(histogram);

            Console.Read();
        }          
        
    }
}
