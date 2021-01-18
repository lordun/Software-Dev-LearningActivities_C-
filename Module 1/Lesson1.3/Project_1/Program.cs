using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write     Line("Hello World")

            string firstStrNumber;
            string secondStrNumber;

            int firstNumber;
            int secondNumber;



            Console.WriteLine("Enter Your First Number:");
            firstStrNumber = Console.ReadLine();

            firstNumber = int.Parse(firstStrNumber);


            Console.WriteLine("Enter Your Second Number:");
            secondStrNumber = Console.ReadLine();

            secondNumber = int.Parse(secondStrNumber);

            Console.WriteLine(firstNumber + secondNumber);

            Console.WriteLine("The Summation of " + firstNumber + " and " + secondNumber + " is: " + (firstNumber + secondNumber));


            Console.Read();
        }
    }
}
