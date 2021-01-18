using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5_matchNameInAllCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string refName = "lora";
            Console.WriteLine("Enter your name:");
            string inputName = Console.ReadLine();

            if (refName == inputName.ToLower())
            {
                Console.WriteLine("It is a match");
                Console.WriteLine("Welcome "+char.ToUpper(refName[0]) + refName.Substring(1));
            }
            else
            {
                Console.WriteLine("It is not a match.");
            }
        }
    }
}
