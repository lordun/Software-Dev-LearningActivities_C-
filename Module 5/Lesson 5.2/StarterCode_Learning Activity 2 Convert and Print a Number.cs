using System;

namespace Activity_5_1_2
{
    class BaseConversion
    {
        private void Binary(int number)
        {
            //toDo
        }
        private void Octal(int number)
        {
           //ToDo
        }
        private void PrintHexDigit(int number)
        {
            //ToDo
        }
        public void Print(int value, int nbase=10)
        {
            //ToDo
        }
    }
    
    class Program
    {
        static void Main(string [] args)
        {
            var num = new BaseConversion();
            int val,nbase;
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                Console.WriteLine("Example: ");
                Console.WriteLine("To print Decimal 4 in Binary: print 4 2");
                Console.WriteLine("To print Decimal 9 in Octal: print 9 8");
                Console.WriteLine("To print Decimal 11 in Decimal: print 11");
                Console.WriteLine("To print Decimal 11 in Hexa-Decimal: print 11 16");
                Console.WriteLine("To exit from the program: exit");

                command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs.Length == 0)
                    continue;
                else if (cmdArgs[0] == "exit") return;
                else if (cmdArgs.Length == 2)
                {
                    if (cmdArgs[0] == "print")
                    {
                        val = int.Parse(cmdArgs[1]);
                        num.Print(val);
                    }
                    else continue;
                }
                else if (cmdArgs.Length == 3)
                {
                    if (cmdArgs[0] == "print")
                    {
                        val = int.Parse(cmdArgs[1]);
                        nbase = int.Parse(cmdArgs[2]);
                        num.Print(val, nbase);
                    }
                    else continue;
                }
                else
                {
                    Console.WriteLine("\nUnknown Command!. Please enter command in proper format.");
                }

                Console.ReadKey();
            }
        }
    }
}
