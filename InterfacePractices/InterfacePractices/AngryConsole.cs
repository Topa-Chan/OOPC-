using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace InterfacePractices
{
    public class AngryConsole : IConsoleViewable
    {
        public void Printinput(string input)
        {
            string angryInput = input.ToUpper();
            Console.WriteLine(angryInput);
        }

        public string PromptForInput()
        {
            string input = CIO.PromptForInput("ENTRE A MESSAGE PLEASE!\n", false);
            return input;
        }

    }
}
