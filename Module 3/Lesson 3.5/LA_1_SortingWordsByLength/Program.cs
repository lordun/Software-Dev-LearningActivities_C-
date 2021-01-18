using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_1_SortingWordsByLength
{
    class Program
    {
        static string SortWords(string[] words)
        {
            int i, j;
            string t;
            for (i = 0; i < words.Length; i++)
            {
                for (j = 1; j < words.Length - 1; j++)
                {
                    if (words[i].Length > (words[j].Length))
                    {
                        t = words[i];
                        words[i] = words[j];
                        words[j] = t;
                    }
                }
            }
            return string.Join(" ", words);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string lineInput = Console.ReadLine();
            string[] words = lineInput.Split(' ');

            lineInput = SortWords(words);
            string[] sortedWords = lineInput.Split(' ');
            Console.WriteLine();
            for (int i = 0; i < sortedWords.Length; i++)
            {
                Console.WriteLine(sortedWords[i] + " ");
            }

            Console.Read();
        }
    }
}
