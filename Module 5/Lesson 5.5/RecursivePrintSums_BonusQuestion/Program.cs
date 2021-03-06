﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity_3_RecursivePrintSums
{
    class Program
    {
        static void DisplayList(List<int> oldList, int space)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < oldList.Count - 1; i++)
            {
                newList.Add(oldList[i] + oldList[i + 1]);
            }
            if (newList.Count >= 1)
            {
                DisplayList(newList, space + 1);
            }
            if (oldList.Count >= 1) //To print in reverse order, take this block and move it before the recursive calls above.
            {
                for (int i = 0; i < space; i++)
                {
                    Console.Write("  ");
                }
                foreach (var item in oldList)
                {
                    Console.Write(string.Format("{0,3}", item) + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            List<int> oldList = new List<int>() { 1, 3, 5, 2, 4 };
            DisplayList(oldList, 0);

            Console.Read();
        }
    }
}
