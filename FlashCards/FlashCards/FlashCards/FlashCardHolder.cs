using CSC150_ConsoleMenu;
using ProgUtilLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
//using System.Security.Principal;

namespace FlashCards
{
    public class FlashCardHolder
    {

        private static Dictionary<string, string> cards = new Dictionary<string, string>();
        public static string key;
        public static string value;
        public static Dictionary<string, string>.KeyCollection keys = cards.Keys;
        public static Dictionary<string, string>.ValueCollection values = cards.Values;
        public static List<string> keyList = new List<string>(cards.Keys);
        public static List<string> valueList = new List<string>(cards.Values);
        public static List<string> keysList = new List<string>();
        public static List<string> valuesList = new List<string>();
        public static Random rand = new Random();
        public static List<string> loading = new List<string>();

        public static void Run()
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            List<string> mainMenu = new List<string>() { "Manage Flash Cards", "Review" };
            int choice = CIO.PromptForMenuSelection(mainMenu, true);
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    ManageFlashCards();
                    break;
                case 2:
                    Review();
                    break;
                case 0:
                    Console.WriteLine("Thank you for using Flash Cards.");
                    break;
                default:
                    break;
            }

        }

        private static void ManageFlashCards()
        {
            Console.WriteLine();
            List<string> manageMenu = new List<string>() { "Add a new flash card", "Remove a flash card", "Save cards", "Load cards", "Back to main menu" };
            int selection = CIO.PromptForMenuSelection(manageMenu, false);
            switch (selection)
            {
                case 1:
                    AddCard();
                    break;
                case 2:
                    RemoveCard();
                    break;
                case 3:
                    SaveCards();
                    break;
                case 4:
                    LoadCards();
                    break;
                case 5:
                    MainMenu();
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }

        private static void Review()
        {
            bool valid = false;
            Console.WriteLine();
            string go;
            do
            {
                int i = rand.Next(keyList.Count);
                Console.WriteLine("Word: " + keyList[i]);
                Console.WriteLine();
                Console.Write("Please press enter to reveal the dictionary or press b to escape\nPlease enter your selection: ");
                go = Console.ReadLine();
                Console.WriteLine();
                if (go == "B" || go == "b")
                {
                    valid = true;
                }
                else if (go == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("Definition: " + valueList[i]);
                    Console.WriteLine();
                }
            } while (!valid);
            Console.WriteLine();
            MainMenu();
        }

        private static void AddCard()
        {
            Console.WriteLine();
            Console.Write("Please entre the word for your flashcard: ");
            key = Console.ReadLine();
            if (cards.Keys.Contains(key))
            {
                Console.WriteLine("This key already exists, please remove it if you would like to change the definition.");
                ManageFlashCards();
            }
            Console.WriteLine();
            Console.Write("Please entre the definition for the word you just entred: ");
            value = Console.ReadLine();
            cards.Add(key, value);
            keyList.Add(key);
            valueList.Add(value);
            Console.WriteLine();
            MainMenu();
        }

        private static void RemoveCard()
        {
            Console.WriteLine();
            Console.WriteLine("Which key would you like to remove?");
            keyList.Sort();
            int choice = CIO.PromptForMenuSelection(keyList, false);
            Console.WriteLine();
            string removeKey = keyList[choice - 1];
            cards.Remove(removeKey);
            keyList.Remove(removeKey);
            valueList.RemoveAt(choice - 1);
            MainMenu();
        }

        private static void SaveCards()
        {
            Console.WriteLine();
            Console.WriteLine("Where would you like to save the file?");
            string location = Console.ReadLine();
            string path = location;
            foreach (string key in keys)
            {
                string saveCard = key + " :: " + cards[key] + "\t";
                if (!File.Exists(path))
                {
                    ProgramUtil.WriteToFile(path, saveCard);
                }
                else
                {
                    File.AppendAllText(path, saveCard);
                }
            }
            Console.WriteLine();
            MainMenu();
        }

        private static void LoadCards()
        {
            Console.WriteLine();
            Console.WriteLine("Which file would you like to load?");
            string location = Console.ReadLine();
            string path = location;
            if (!File.Exists(path))
            {
                Console.WriteLine("The path you indicated is invalid.");
                ManageFlashCards();
            }
            else
            {
                string lines = ProgramUtil.ReadFile(path);
                Console.WriteLine(lines);
                int k = 0;
                int v = 2;
                int t = 0;
                string[] splitLines = lines.Split('\t');
                foreach (string s in splitLines)
                {
                    Console.WriteLine(s);
                    string[] splitS = s.Split(' ');
                    foreach (string i in splitS)
                    {
                        Console.WriteLine("SplitS LgntH: " + splitS.Length);
                        Console.WriteLine("I lgnth: " + i.Length);
                        Console.WriteLine("SplitLines lgnth: " + splitLines.Length);
                        int totallngth = splitLines.Length * splitS.Length;
                        Console.WriteLine("Total (SplitS & Lines): " + totallngth);
                        string[] addingStrings = new string[totallngth];
                        addingStrings[0] = i;
                        if (k >= totallngth || v >= totallngth)
                        {
                            Console.WriteLine("Moo");
                        }
                        else
                        {
                            keyList.Add(addingStrings[k]);
                            Console.WriteLine("Added Key");
                            Console.WriteLine("Key: " + k);
                            valueList.Add(addingStrings[v]);
                            Console.WriteLine("Added Value");
                            Console.WriteLine("Value: " + v);
                            k += 3;
                            v += 3;
                        }
                    }
                }
            }
            Console.WriteLine();
            MainMenu();
        }
    }

}

