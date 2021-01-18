using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity2_DicePool
{
    public class SingleDie
    {
        private int _sides;
        private Random r;
        public int Sides { get; private set; }

        public SingleDie(int Sides)
        {
            _sides = Sides;
            r = new Random();
        }
        public int Roll()
        {
            return r.Next(1, _sides + 1);
        }
    }
    public class PoolOfDice
    {
        private List<SingleDie> dicePool;
        public PoolOfDice()
        {
            dicePool = new List<SingleDie>();
        }
        public void Add(int Sides)
        {
            SingleDie newDice = new SingleDie(Sides);
            dicePool.Add(newDice);
        }
        public bool Remove(int Sides)
        {
            SingleDie deleteDice = dicePool.Find(a => a.Sides == Sides);
            if (deleteDice != null)
            {
                dicePool.Remove(deleteDice);
                return true;
            }
            return false;
        }
        public int Roll (int Sides)
        {
            SingleDie findDice = dicePool.Find(a => a.Sides == Sides);
            if (findDice == null)
            {
                return -1;
            }
            return findDice.Roll();
        }
        public int RollAll()
        {
            int sum = 0;
            int t;
            foreach (var item in dicePool)
            {
                t = item.Roll();
                Console.WriteLine("The dice with " + item.Sides + " sides landed on: " + t);
                sum = t;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string commandLine;
            string[] command;
            PoolOfDice dice =  new PoolOfDice();
            int result;
            do
            {
                Console.WriteLine("Please enter a command: ");
                commandLine = Console.ReadLine();
                commandLine = commandLine.ToLower();
                commandLine = commandLine.Trim();
                while (commandLine.Contains("  "))
                {
                    commandLine.Replace("  ", " ");
                }
                command = commandLine.Split(' ');
                if (command[0]== "add")
                {
                    dice.Add(int.Parse(command[1]));
                    Console.WriteLine(command[1] + " sided die has been added.");
                }
                else if (command[0] == "remove")
                {
                    if (dice.Remove(int.Parse(command[1])) == true)
                    {
                        Console.WriteLine("The " + command[1] + " sided dice was deleted.");
                    }
                    else
                    {
                        Console.WriteLine("The " + command[1] + " sided dice was not found.");
                    }
                }
                else if (command[0] == "roll")
                {
                    result = dice.Roll(int.Parse(command[1]));

                    if (result == -1)
                    {
                        Console.WriteLine("The " + command[1] + " sided dice is not available.");
                    }
                    else
                    {
                        Console.WriteLine("The dice with " + command[1] + " sides landed on: " + result);
                    }
                }
                else if (command[0] == "rollall")
                {
                    result = dice.RollAll();
                    Console.WriteLine("The sum of all the landed rolls are: " + result);
                }
                else
                {
                    Console.WriteLine("Please enter using the correct format.");
                }
            } while (commandLine != "exit");
        }
    }
}
