using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myMessage;
            //myMessage = "Programming is fun!";

            //myMessage=myMessage.ToUpper();
            //bool flag;
            //flag=myMessage.Contains("FUN");

            //string mySubString;
            //mySubString = myMessage.Substring(0,11);
            //Console.WriteLine(mySubString);

            //Console.WriteLine(myMessage.Length);

            //Console.WriteLine(myMessage);
            //Console.WriteLine(flag);
            //Console.Read();

            Console.WriteLine("Enter temperature in C");
            float C = float.Parse(Console.ReadLine());
            float F = 9*C/5+32;
            Console.WriteLine("F temperature is: " + F +" degrees");
            Console.ReadLine();
 

        }
    }
}
