using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace Parcel_Sorter
{
    public class Program
    {

        public static List<Parcel> packages = new List<Parcel>();
        private static bool valid = false;
        private static int parcelCount = 1;

        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            do
            {
                int parcel = CIO.PromptForInt("Entre how many parcles you would like to ship: ", 1, int.MaxValue);
                for (int i = 0; i < parcel; i++)
                {
                    Console.WriteLine("Parcel " + parcelCount++ + "\n");
                    float weight = CIO.PromptForFloat("Entre the weight of your parcel: ", 0, float.MaxValue);
                    float height = CIO.PromptForFloat("Entre the height of your parcel in inches: ", 0, float.MaxValue);
                    float width = CIO.PromptForFloat("Entre the width of your parcel in inches: ", 0, float.MaxValue);
                    float depth = CIO.PromptForFloat("Entre the depth of your parcel in inches: ", 0, float.MaxValue);
                    packages.Add(new Parcel(weight, width, height, depth));
                }
                packages.Sort();
                foreach (Parcel p in packages)
                {
                    Console.WriteLine(p);
                }
                packages.Clear();
                Console.WriteLine();
                bool done = false;
                do
                { 
                    Console.WriteLine("Would you like to ship any additional packages?");
                    Console.Write("Please entre you answer as either (y/n): ");
                    string input = Console.ReadLine();
                    if (input == "y" || input == "Y")
                    {
                        valid = false;
                        done = true;
                    }
                    else if (input == "n" || input == "N")
                    {
                        valid = true;
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Please entre a valid input.");
                    }
                } while (!done);
            } while (!valid);
            Console.WriteLine("\nThank you for using Parcel Sorter.");
        }
    }
}
