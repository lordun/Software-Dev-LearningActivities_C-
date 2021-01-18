using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity_1_Bonus
{
    class Program
    {
        static string SortWords(string[] words)
        {
            int i, j;
            string t;
            for (i = 0; i < words.Length; i++)
            {
                for (j = 0; j < words.Length; j++)
                {
                    if (words[i].Length < (words[j].Length))
                    {
                        t = words[i];
                        words[i] = words[j];
                        words[j] = t;
                    }
                    else if (words[i].Length == (words[j].Length))
                    {
                        if (words[i].CompareTo(words[j]) < 0)
                        {
                            t = words[i];
                            words[i] = words[j];
                            words[j] = t;
                        }
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


            foreach (var word in sortedWords)
            {
                Console.WriteLine(word + " ");
            }

            Console.Read();
        }
    }
}
