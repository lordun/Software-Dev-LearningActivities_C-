using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_daysOfTheWeek
{
    class Program
    {
    		public enum Days
		{
			Monday = 1,
			Tuesday = 2,
			Wednesday = 3,
			Thursday = 4,
			Friday = 5,
			Saturday = 6,
			Sunday = 7
		};

		static void Main(string[] args)
		{
			Console.WriteLine("Day of the Week!");
			Console.WriteLine("Please enter a number (between 1 to 7)\n");

			//Days day;
			//Enum.TryParse(Console.ReadLine(), out day);

			Days day = (Days)Enum.Parse(typeof(Days), Console.ReadLine());

			Console.Write("Your selection is: ");
			switch (day)
			{
				case Days.Monday:
					Console.WriteLine("Monday");
					break;
				case Days.Tuesday:
					Console.WriteLine("Tuesday");
					break;
				case Days.Thursday:
					Console.WriteLine("Thursday");
					break;
				case Days.Friday:
					Console.WriteLine("Friday");
					break;
				case Days.Saturday:
					Console.WriteLine("Saturday");
					break;
				case Days.Sunday:
					Console.WriteLine("Sunday");
					break;
				default:
					Console.WriteLine("Invalid selection\nPlease try again in the next run!");
					break;
			}

			Console.Read();
		}
	}
    }

