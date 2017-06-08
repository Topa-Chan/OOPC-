using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgUtilLib;

namespace ProgramUtilTester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ProgramUtil.Factorial(5));
            Console.WriteLine(ProgramUtil.ParseInt("-23"));
            Console.WriteLine(ProgramUtil.TryParseInt("-50"));
            Console.WriteLine(ProgramUtil.ReadFile(@"C:\Users\Tyler\Desktop\Games\Crying.txt"));
            string input = "I'm crying because I don't remember why I created this txt file.";
            ProgramUtil.WriteToFile(@"C:\Users\Tyler\Desktop\Games\Crying.txt", input);
        }
    }
}
