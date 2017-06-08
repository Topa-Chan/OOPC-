using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgUtilLib
{
    public static class ProgramUtil
    {

        //Pseudo code for parsing an int
        //1. Make sure input is not null nor empty
        //  a. If it is null or empty, input is invalid ~
        //2. Trim the input and store a new string into a new local variable ~
        //3. Check for positive or negative (check to see if the first char is '-')
        //  a. If the first char is '-' the parsed int is negative
        //4. Loop through the remaining characters and... 
        //  a. If the current char is between '0' and '9' inclusive (or 48 and 57 inclusive)...
        //      i. Do the math
        //  b. Else, input is invalid
        //5. If input is invalid 
        //  a. Throw FormatException with custom, useful, constructive, kind message
        //6. Else, return the int

        public static int ParseInt(string input)
        {
            bool isNeg = false;
            int multiplier = 1;
            int num = 0;
            long intCheck = num;
            if (input == null || input == "")
            {
                throw new FormatException("Your input cannot be null or empty.");
            }
            else
            {
                string triminput = input.Trim();
                if (triminput[0] == '-')
                {
                    isNeg = true;
                    triminput = triminput.TrimStart('-');
                }
                else if (triminput[0] < '0' || triminput[0] > '9')
                {
                    throw new FormatException("Your input cannot begin with an unknown character.");
                }
                if (isNeg)
                {
                    intCheck -= 1;
                }
                for (int i = triminput.Length - 1; i >= 0; i--)
                {
                    if (triminput[i] >= '0' && triminput[i] <= '9')
                    {
                        intCheck += (triminput[i] - 48) * multiplier;
                    }
                    else
                    {
                        throw new FormatException("Your input cannot have any unknown characters.");
                    }
                    if (intCheck > int.MaxValue || intCheck < int.MinValue)
                    {
                        throw new FormatException("Your input must be within the values of an integer.");
                    }
                    multiplier *= 10;
                }
                if (isNeg)
                {
                    intCheck += 1;
                    intCheck *= -1;
                }
                num = (int)intCheck;
                return num;
            }
        }

        public static TryParseIntResult TryParseInt(string input)
        {
            bool didParse;
            int? result;
            try
            {
                result = ParseInt(input);
            }
            catch (Exception)
            {
                return new TryParseIntResult(false, null);
            }
            return new TryParseIntResult(true, result);
        }

        public static long Factorial(int num)
            {
                long product;
                if (num < 0 || num > 20)
                {
                    throw new ArgumentException("Your input must be between 0 and 20 inclusive.");
                }
                else if (num == 0)
                {
                    return 1;
                }
                else
                {
                    product = num * Factorial((num - 1));
                    return product;
                }
            }

            public static string ReadFile(string filePath)
            {
                string filer = "";
                try
                {
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        filer += sr.ReadToEnd();
                    }
                }
                catch (FileNotFoundException)
                {
                    throw new FileNotFoundException("No file found for path [" + filePath + "].");
                }
                return filer;
            }

            public static void WriteToFile(string filePath, string output)
            {
                if (filePath == null || output == null)
                {
                    throw new ArgumentException("Your filePath or output must not be null.");
                }
                try
                {
                    System.IO.File.WriteAllText(filePath, output);
                }
                catch (DirectoryNotFoundException)
                {
                    throw new DirectoryNotFoundException("Your intended directory does not exist, please check your filePath.");
                }
            }
        }
    }
