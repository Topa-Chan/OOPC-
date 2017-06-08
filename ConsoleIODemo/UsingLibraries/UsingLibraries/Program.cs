using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace UsingLibraries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = CIO.PromptForInput("Enter Stuff: ", false);
            Console.WriteLine("CIO returned: " + input);

            List<string> Cows = new List<string>() { "Joe", "John", "Jim" };
            CIO.PromptForMenuSelection(Cows, true);
            
        }
    }
}
