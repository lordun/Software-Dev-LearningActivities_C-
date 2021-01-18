using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_WatersStateTernary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the water's temperature in °C: ");
            int temperature= int.Parse(Console.ReadLine());
            
            string state = temperature <= 0 ? "The physical state is a solid" : (temperature <= 100 ? "The physical state is a liquid":"The physical state is a gas");
            Console.WriteLine(state);
            Console.Read();
        }
    }
}
        
    

