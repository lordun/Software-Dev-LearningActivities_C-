using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity2_ConvertAndPrintADecimalNumberToDifferentBases
{
    class BaseConversion
    {
        private string Binary(int number)
        {
            int num = number;
            int quotient;
            string remainder = "";
            while (num >= 1)
            {
                quotient = num / 2;
                remainder += (num % 2).ToString();
                num = quotient;
            }
            string binary = "";
            for (int i = remainder.Length - 1; i >= 0; i--)
            {
                binary = binary + remainder[i];
            }
            return binary;
        }
        private string Octal(int number)
        {
            int num = number;
            int quotient;
            string remainder = "";
            while (num >= 1)
            {
                quotient = num / 8;
                remainder += (num % 8).ToString();
                num = quotient;
            }
            string octal = "";
            for (int i = remainder.Length - 1; i >= 0; i--)
            {
                octal = octal + remainder[i];
            }
            return octal;
        }
        private string PrintHexDigit(int number)
        {
            string hexStr = null;
            int n = number;
            int r;
            do
            {
                r = n % 16;
                if (r > 9)
                {
                    hexStr += (char)('A' + (r - 10));
                }
                else
                {
                    hexStr += r;
                }
                n /= 16;
            } while (n > 0);

            char[] hCA = hexStr.ToCharArray();
            Array.Reverse(hCA);
            hexStr = new string(hCA);
            return hexStr;
        }
        public void Print(int value, int nbase = 10)
        {
            if (nbase == 10)
            {
                Console.WriteLine("Decimal value: " + value);
            }
            else if (nbase == 2)
            {
                Console.WriteLine("Decimal value " + value + " in Binary is: "+ Binary(value));
            }
            else if (nbase == 8)
            {
                Console.WriteLine("Decimal value " + value + " in Octal is: " + Octal(value));
            }
            else if (nbase == 16)
            {
                Console.WriteLine("Decimal value " + value + " in Hexa-Decimal is: " + PrintHexDigit(value));
            }
            else
            {
                Console.WriteLine("Unknown Base, please try again!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var num = new BaseConversion();
            int val, nbase;
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
