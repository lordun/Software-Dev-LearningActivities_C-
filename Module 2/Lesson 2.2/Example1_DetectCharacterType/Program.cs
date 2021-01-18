using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_DetectCharacterType
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a character");
			char c = char.Parse(Console.ReadLine());

			//if (char.IsUpper(c))
			{
				//Console.WriteLine("Upper Case character");
			}
			//else if (char.IsLower(c))
			{
				//Console.WriteLine("Lower Case character");
			}

			if (char.IsUpper(c) || char.IsLower(c))
			{
				c = char.ToLower(c);
				if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')

					Console.WriteLine("Vowel character");
				else
					Console.WriteLine("Consanant character");
			}

			else if (char.IsDigit(c))
			{
				Console.WriteLine("Digit character");
			}
			else
			{
				Console.WriteLine("Other character");
			}

				Console.Read();

			
		}
    }
}
