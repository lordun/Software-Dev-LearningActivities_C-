using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age=int.Parse(Console.ReadLine());
         

            Console.WriteLine("Hello "+name + " ("+ age+")"+"!");
            Console.Read();
            




        }
    }
}
