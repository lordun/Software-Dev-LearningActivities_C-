using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_3
{
    class Program
	{ 
    			public static void Greeting(string name)
			{
				Console.WriteLine("Hi "+name+"!");
				Console.WriteLine("Thank you very much for shopping with us.");
				Console.WriteLine("Our shop usually keeps special offers for customers like you;  " + name + ".");
				Console.WriteLine("So  " + name + ", do you want to explore your offer?");
			}
			
			static void Main(string[] args)
			{
				Greeting("Alex");
				Console.WriteLine();
				Greeting("Susan");
				Console.WriteLine();
				Greeting("Ken");
				Console.WriteLine();

				Console.ReadLine();
			}
    }
}
