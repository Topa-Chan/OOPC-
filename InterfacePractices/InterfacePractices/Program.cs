using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractices
{

    public interface IConsoleViewable
    {
        string PromptForInput();
        void Printinput(string input);
    }

    public class Program
    {

        static IConsoleViewable Console;

        public Program(IConsoleViewable console)
        {
            Console = console;
        }

        public static void Run()
        {
            string input = Console.PromptForInput();
            Console.Printinput(input);
        }

    }
}
