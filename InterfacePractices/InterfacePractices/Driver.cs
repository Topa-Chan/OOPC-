using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgUtilLib;

namespace InterfacePractices
{

    public class Driver
    {

        public static void Main(string[] args)
        {
            Start(args);
        }

        public static void Start(string[] menu)
        {
            if (menu.Length == 0)
            {
                new Program(new PirateConsole());
            }
            else if (ProgramUtil.TryParseInt(menu[0]).didParse)
            {
                int choice = ProgramUtil.ParseInt(menu[0]);
                switch (choice)
                {
                    case 1:
                        new Program(new PirateConsole());
                        break;
                    case 2:
                        new Program(new PrettyConsole());
                        break;
                    case 3:
                        new Program(new AngryConsole());
                        break;
                    default:
                        new Program(new PirateConsole());
                        break;
                }
            }
            else
            {
                new Program(new PirateConsole());
            }
            Program.Run();
        }
    }
}
