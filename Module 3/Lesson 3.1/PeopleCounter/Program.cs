using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCounter
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Just hit \'enter\' whenever someone entered the BUS:");
			int peopleCounter = 0;
			while (Console.ReadLine() == "")
			{
				peopleCounter++;
				Console.Clear();
				Console.WriteLine("Write Something and hit \'enter\' to finish counting.");
				Console.WriteLine("Total People entered the bus (so far): " + peopleCounter);
			}
			Console.Clear();
			Console.Write("Total People Count is: " + peopleCounter);
			Console.Read();
		}
	}
}
