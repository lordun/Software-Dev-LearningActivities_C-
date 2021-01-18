using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingDataInTwoLists_Mahbub
{
    class Program
    {
        static void Display(List<int>myList,string listName)
        {
            Console.WriteLine("The elements of the " + listName + " are: ");
                myList.Sort();
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            string input;
            string[] split;
            do
            {
                Console.WriteLine("Please enter your command");
                input = Console.ReadLine();
                input = input.ToLower();

                while (input.Contains("  ")) input = input.Replace("  ", " ");
                input = input.Trim();
                split = input.Split(' ');

                if (split[0].CompareTo("display") == 0)
                {
                    Display(oddList, "Odd List");
                    Display(evenList, "Even List");
                }
                else if (split[0].CompareTo("add") == 0)
                {
                    int val;
                    for (int i = 1; i < split.Length; i++)
                    {
                        val = int.Parse(split[i]);
                        if (val % 2 == 0)
                        {
                            evenList.Add(val);
                        }
                        else
                        {
                            oddList.Add(val);
                        }
                    }
                }
                else if (split[0].CompareTo("delete") == 0)
                {
                    int val;
                    for (int i = 1; i < split.Length; i++)
                    {
                        val = int.Parse(split[i]);
                        if (val % 2 == 0)
                        {
                            evenList.Remove(val);
                        }
                        else
                        {
                            oddList.Remove(val);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nUnknown command entered. Please enter a valid command\n");
                }
            } while (input.CompareTo("exit") != 0);
        }
    }
}
