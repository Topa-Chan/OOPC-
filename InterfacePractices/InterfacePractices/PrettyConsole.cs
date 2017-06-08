using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace InterfacePractices
{
    public class PrettyConsole : IConsoleViewable
    {
        public void Printinput(string input)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(input);
        }

        public string PromptForInput()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            string input = CIO.PromptForInput("Please entre a beautiful message: ", false);
            return input;
        }

    }
}
