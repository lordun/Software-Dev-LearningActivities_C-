using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivityCircumAreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your radius value: ");
            float r= float.Parse(Console.ReadLine());
            
            const float PI = 3.141592654f;
            float circum = 2 * PI * r;
            float area = PI * r * r;
            Console.WriteLine("The circumference of the circle is: "+ circum);
            Console.WriteLine("The area of the circle is: " + area);                   
           
           
        }
    }
}
