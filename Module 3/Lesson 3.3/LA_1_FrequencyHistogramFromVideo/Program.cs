using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_1_FrequencyHistogramFromVideo
{
    class Program
    {
        static void Display (int[]x)
        {
            Console.WriteLine("\nThe elements of the array are: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        static void DisplayHistogram (int [] histogram)
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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the random seed number for the array: ");
            int seed = int.Parse(Console.ReadLine());

            int[] x;
            Random r = new Random(seed);
            x = new int[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = r.Next(0, 5);
            }
            Display(x);

            int[] histogram = new int[5];
                for (int i = 0; i < n; i++)
            {
                histogram[x[i]]++;
            }
            Console.WriteLine();
            DisplayHistogram(histogram);

            Console.Read();
        }
    }
}
