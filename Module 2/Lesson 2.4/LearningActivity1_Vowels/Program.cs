using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_Vowels
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a lowercase letter: ");
			char letter = char.Parse(Console.ReadLine());
			letter = char.ToLower(letter);

			Console.Write("The letter you chose ");
			switch (letter)
			{
				case 'a':
				case 'e':
				case 'i':
				case 'o':
				case 'u':
					Console.WriteLine("is a vowel");
					break;
				case 'b':
				case 'c':
				case 'd':
				case 'f':
				case 'g':
				case 'h':
				case 'j':
				case 'k':
				case 'l':
				case 'm':
				case 'n':
				case 'p':
				case 'q':
				case 'r':
				case 's':
				case 't':
				case 'v':
				case 'w':
				case 'x':
				case 'z':
					Console.WriteLine("is a consonant");
					break;
				case 'y':
					Console.WriteLine("is sometimes a vowel");
					break;
				default:
					Console.WriteLine("is Invalid input");
					break;
			}

			Console.Read();
		}
	}
}


        
    

