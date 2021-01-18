using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_ReformatNameAndAddTitle
{
	class Program
	{
		static void FormatName(ref string name, string title)
		{
			string[] words = name.Split(' ');
			string formatName = title + " " + words[words.Length - 1] + " ";
			for (int i = 0; i < words.Length - 1; i++)
			{
				formatName += words[i][0] + ". ";
				name = formatName;
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a Full Name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Enter a Professional Title: ");
			string title = Console.ReadLine();

			FormatName(ref name, title);
		
			Console.WriteLine("The formatted name is: " + name);

			Console.ReadLine();
		}
	}
}
