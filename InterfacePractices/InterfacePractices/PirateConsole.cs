using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace InterfacePractices
{
    public class PirateConsole : IConsoleViewable
    {

        public void Printinput(string input)
        {
            string pirateInput = input.Replace("r", "-ARR-");
            pirateInput += ", me harty!";
            Console.WriteLine(pirateInput);
        }

        public string PromptForInput()
        {
            string input = CIO.PromptForInput("Arrr, matey! Entre a message 'n you'll get some o' me rum!\n", false);
            return input;
        }

    }
}
