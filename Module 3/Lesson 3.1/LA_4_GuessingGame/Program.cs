using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_4_GuessingGame
{
    class Program
    {
        static int TakeValidIntInput()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input, please try again");
            }
            return n;
        }
        static char TakeYNInput()
        {
            char c;
            while (!char.TryParse(Console.ReadLine(), out c) || !(c == 'y' || c == 'Y' || c == 'n' || c == 'N'))
            {
                Console.WriteLine("Incorrect input, please try again");
            }
            return c;

        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int rVal;
            int guess;
            int count;
            char c;

            do 
            {
                rVal = r.Next(1, 101);
                count = 0;
                Console.Clear();
                Console.WriteLine("Please guess the number from 1 to 100");
                
            do
            {
                guess = TakeValidIntInput();
                count++;

                if (guess < rVal)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if (guess > rVal)
                {
                    Console.WriteLine("Guess Lower");
                }
                else
                {
                    Console.Write("Correct! You used "+count+" guess");
                    if(count==1)
                    {
                        Console.WriteLine("!");
                    }
                    else
                    {
                        Console.WriteLine("es.");
                    }
                }

            } while (guess!= rVal);

                    Console.WriteLine("Do you want to play again? (Y/N)");

                    c = TakeYNInput();

            } while (c=='y'|| c=='Y');
        }
    }
}
