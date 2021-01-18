using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity2_DicePool
{
    public class Dice
    {
        private Random r;
        public int Side { get; private set; }
        public Dice (int s)
        {
            Side = s;
            r = new Random();
        }
        public int Roll()
        {
            return r.Next(1, Side + 1);
        }
    }

    public class DicePool
    {
        private List<Dice> dicePool;
        public DicePool()
        {
            dicePool = new List<Dice>();
        }
        public void Add (int s)
        {
            Dice newDice = new Dice(s);
            dicePool.Add(newDice);
        }
        public bool Remove (int s)
        {
            Dice delDice = dicePool.Find(a => a.Side == s);
            if (delDice!=null)
            {
                dicePool.Remove(delDice);
                return true;
            }
            return false;
        }
        public int Roll (int s)
        {
            Dice findDice = dicePool.Find(a => a.Side == s);
            if (findDice==null)
            {
                return -1;
            }
            return findDice.Roll();
        }
        public int RollAll()
        {
            int sum = 0;
            int t;
            foreach (var d in dicePool)
            {
                t = d.Roll();
                Console.WriteLine("The dice with " + d.Side + " sides landed on: " + t);
                sum += t;
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string[] word;
            DicePool dPool = new DicePool();
            int result;

            do
            {
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine();
                command = command.ToLower();
                command = command.Trim();
                while (command.Contains("  "))
                {
                    command.Replace("  ", " ");
                }
                word = command.Split(' ');
                if (word[0] == "add")
                {
                    dPool.Add(int.Parse(word[1]));
                    Console.WriteLine(word[1] + " sided die has been added.");
                }
                else if (word[0] == "remove")
                {
                    if (dPool.Remove(int.Parse(word[1])) == true)
                    {
                        Console.WriteLine("The " + word[1] + " sided dice was deleted.");
                    }
                    else
                    {
                        Console.WriteLine("The " + word[1] + " sided dice was not found.");
                    }
                }
                else if (word[0] == "roll")
                {
                    result = dPool.Roll(int.Parse(word[1]));

                    if (result == -1)
                    {
                        Console.WriteLine("The " + word[1] + " sided dice is not available.");
                    }
                    else
                    {
                        Console.WriteLine("The dice with " + word[1] + " sides landed on: " + result);
                    }
                }
                else if (word[0] == "rollall")
                {
                    result = dPool.RollAll();
                    Console.WriteLine("The sum of all the landed rolls are: " + result);
                }
                else
                {
                    Console.WriteLine("Please enter using the correct format.");
                }
            } while (command != "exit");
        }
    }
}
