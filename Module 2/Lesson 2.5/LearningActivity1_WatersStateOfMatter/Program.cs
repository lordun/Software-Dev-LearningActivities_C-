using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_WatersStateOfMatter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int temperature;

            Console.WriteLine("Enter the water's temperature in °C: ");
            temperature = int.Parse(Console.ReadLine());

            if (temperature <= 0)
            {
                Console.WriteLine("The water is in the solid state.");
            }
            else if (temperature >0 && temperature <= 100)
            {
                Console.WriteLine("The water is in the liquid state.");
            }
            else 
            {
                Console.WriteLine("The water is in the gas state.");
            }
            Console.Read();
        }
    }
}
