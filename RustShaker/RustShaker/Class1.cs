using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustShaker.Enums;

namespace RustShaker
{
    class BuildBear
    {
        int choice;
        string[] names = new string[] { "Panda", "Pooh-Bear", "Teddi", "Snuggles", "Rawr", "Mrs. Nesbitt", "Roosevelt" };
        string[] colours = new string[] { "Black", "Blue", "Green", "Yellow", "Brown", "Magenta", "Pink", "Red" };

        Random rand = new Random();

        public void Run()
        {
            bool valid = false;
            bool done = false;

            do
            {
                Console.WriteLine("Build-A-Bear Workshop");
                Console.WriteLine("1. Build A Custom Bear.");
                Console.WriteLine("2. Build A Default Bear.");
                Console.WriteLine("3. Quit.");
                Console.Write("Please enter your choice: ");
                string input = Console.ReadLine();
                valid = int.TryParse(input, out choice) && 1 <= choice && choice <= 3;
                Console.WriteLine();
                if (!valid)
                {
                    Console.WriteLine("Please Enter A Valid Choice.");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Build A Custom Bear.");
                        Console.WriteLine(CustomBear().ToString());
                        break;
                    case 2:
                        Console.WriteLine("Build A Default Bear.");
                        Console.WriteLine(DefaultBear().ToString());
                        break;
                    case 3:
                        Console.WriteLine("Thank You For Visiting Build-A-Bear Workshop!");
                        done = true;
                        break;
                }
                Console.WriteLine();
            } while (!done);
        }

        public Bear DefaultBear()
        {
            Console.WriteLine();
            return new Bear();
        }

        public Bear CustomBear()
        {
            int n = rand.Next(names.Length);
            int c = rand.Next(colours.Length);
            int weight = rand.Next(1, 451);
            int age = rand.Next(1, 6);
            string randName = names[n];
            string randColour = colours[c];
            BearType flavourType = (BearType)(rand.Next(9));
            //string[] flavour = Enum.GetNames(typeof(BearType));
            //int f = rand.Next(flavour.Length);
            //string randFlavour = flavour[f];
            return new Bear(randColour, weight, age, flavourType, randName);
        }
    }
}
