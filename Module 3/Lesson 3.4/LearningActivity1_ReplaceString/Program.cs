using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_ReplaceString
{
    class Program
    {
        static string MultiLineInput()
        {
            Console.WriteLine("Enter a multi-Line input: ");
            string input = " ";
            string sentence;
            do
            {
                sentence = Console.ReadLine();
                input += sentence + "\n";
            } while (sentence.Length > 0);
            return input;
        }
        static void SearchReplace()
        {
            string input = MultiLineInput();
            Console.WriteLine("Enter word to search: ");
            string search = Console.ReadLine();
            Console.WriteLine("Enter word to replace:");
            string replace = Console.ReadLine();
            
            
            string change = input.Replace(search,replace);
            Console.WriteLine(change);
            

            
            

        }
            
        
        static void Main(string[] args)
        {
            SearchReplace();

            Console.Read();
        }
    }
}
