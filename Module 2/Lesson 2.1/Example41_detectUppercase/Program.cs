using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example41_detectUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            char c;
            bool flag = char.TryParse(Console.ReadLine(), out c);
            Console.WriteLine(c);

            if (flag == true)
            {
                if (char.IsUpper(c))
                {
                    Console.WriteLine(c + " is an Uppercase letter");
                }
                else
                {
                    Console.WriteLine(c + " is not in Uppercase");
                }
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }
    }
}
