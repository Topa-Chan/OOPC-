using System;
using System.Collections.Generic;

namespace CSC150_ConsoleMenu
{
    public static class CIO
    {

        public static int PromptForMenuSelection(IEnumerable<string> options, bool withQuit)
        {
            int i = 0;
            bool valid = false;
            bool done = false;
            int choice;
            int q = 1;
            foreach (string selection in options)
            {
                Console.WriteLine(++i + ". " + selection);
            }
            if (withQuit == true)
            {
                q = 0;
                Console.WriteLine();
                Console.WriteLine(q + ". Quit");
            }
            do
            {
                Console.Write("Please select an option: ");
                string input = Console.ReadLine();
                valid = int.TryParse(input, out choice) && q <= choice && choice <= i;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
                else
                {
                    done = true;
                }
            } while(!done);
            return choice;
        }

        public static bool PromptForBool(string message, string trueString, string falseString)
        {
            Console.WriteLine(message);
            bool valid;
            string input = Console.ReadLine();
            if (input.ToUpper() == trueString)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        public static byte PromptForByte(string message, byte min, byte max)
        {
            bool valid = false;
            byte bit;
            do
            {
                Console.WriteLine(message + min + ", " + max);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = byte.TryParse(input, out bit) && min <= bit && bit <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return bit;
        }

        public static short PromptForShort(string message, short min, short max)
        {
            bool valid = false;
            short shorty;
            do
            {
                Console.WriteLine(message + min + ", " + max);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = short.TryParse(input, out shorty) && min <= shorty && shorty <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return shorty;
        }

        public static int PromptForInt(string message, int min, int max)
        {
            bool valid = false;
            int inty;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = int.TryParse(input, out inty) && min <= inty && inty <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return inty;
        }

        public static long PromptForLong(string message, long min, long max)
        {
            bool valid = false;
            long longer;
            do
            {
                Console.WriteLine(message + min + ", " + max);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = long.TryParse(input, out longer) && min <= longer && longer <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return longer;
        }

        public static float PromptForFloat(string message, float min, float max)
        {
            bool valid = false;
            float floater;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = float.TryParse(input, out floater) && min <= floater && floater <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return floater;
        }

        public static double PromptForDouble(string message, double min, double max)
        {
            bool valid = false;
            double doubly;
            do
            {
                Console.WriteLine(message + min + ", " + max);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = double.TryParse(input, out doubly) && min <= doubly && doubly <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return doubly;
        }

        public static decimal PromptForDecimal(string message, decimal min, decimal max)
        {
            bool valid = false;
            decimal decy;
            do
            {
                Console.WriteLine(message + min + ", " + max);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = decimal.TryParse(input, out decy) && min <= decy && decy <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return decy;
        }

        public static string PromptForInput(string message, bool allowEmpty)
        {
            bool valid = false;
            string input = "";
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (allowEmpty == false)
                {
                    if (input == "")
                    {
                        Console.WriteLine("Please entre a valid input.");
                        Console.WriteLine();
                    }
                    else
                    {
                        valid = true;
                    }
                }
                else
                {
                    valid = true;
                }
            } while (!valid);
            return input;
        }

        public static char PromptForChar(string message, char min, char max)
        {
            bool valid = false;
            char chary;
            do
            {
                Console.WriteLine(message + min + ", " + max);
                string input = Console.ReadLine();
                Console.WriteLine();
                valid = char.TryParse(input, out chary) && min <= chary && chary <= max;
                if (!valid)
                {
                    Console.WriteLine("Please entre a valid input.");
                    Console.WriteLine();
                }
            } while (!valid);
            return chary;
        }
    }
}
