using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;
using LootGenerator.Items;
using LootGenerator.Characters;

namespace LootGenerator
{
    public class LootGenerator
    {
        public static List<string> menu = new List<string>() { "Generator 1 Loot Item.", "Generate Some Loot Items.", "Generate n  Loot Items.", "Demonstrate Consumables." };
        public static Random rand = new Random();
        public static List<Item> loot = new List<Item>();

        public static void Run()
        {
            int choice = CIO.PromptForMenuSelection(menu, true);
            switch (choice)
            {
                case 1:
                    GenerateLoots(1);
                    break;
                case 2:
                    GenerateLoots(rand.Next(1, 11));
                    break;
                case 3:
                    int n = GenerateN();
                    GenerateLoots(n);
                    break;
                case 4:
                    DemonstrateConsumables();
                    break;
                default:
                    break;
            }
        }

        public static void GenerateLoots(int l)
        {
            Console.WriteLine();
            Console.WriteLine("Generating loot!");
            int gen;
            for (int i = 0; i < l; i++)
            {
                gen = rand.Next(4);
                switch (gen)
                {
                    case 0:
                        loot.Add(ItemGen());
                        break;
                    case 1:
                        loot.Add(HealGenerator());
                        break;
                    case 2:
                        loot.Add(DamagerGenerator());
                        break;
                    case 3:
                        loot.Add(ArmourGenerator());
                        break;
                    default:
                        break;
                }
            }
            DisplayLoot(loot);
        }

        public static void DisplayLoot(List<Item> loots)
        {
            foreach (Item lootItem in loots)
            {
                Console.WriteLine(lootItem + "\n");
            }
            Run();
        }

        public static int GenerateN()
        {
            int loot = CIO.PromptForInt("Please entre the number of loot you would like to recieve: ", 1, int.MaxValue);
            return loot;
        }

        public static void DemonstrateConsumables()
        {
            Console.WriteLine("Items: \nPotion\nStatus Potion\nCharacter Candy\nGood");
            Character a = CharacterCreator();
            Console.WriteLine("\n" + a.ToString()  + "\n");
            int demCon = rand.Next(4);
            switch(demCon)
            {
                case 0:
                    Potion p = HealGenerator();
                    Console.WriteLine(p.ToString());
                    p.Use(a);
                    break;
                case 1:
                    CharacterCandy cc = CandyGen();
                    Console.WriteLine(cc.ToString());
                    cc.Use(a);
                    break;
                case 2:
                    Good g = GoodGen();
                    Console.WriteLine(g.ToString());
                    g.Use(a);
                    break;
                case 3:
                    StatusPotion sp = StatusGenerator();
                    Console.WriteLine(sp.ToString());
                    sp.Use(a);
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n" + a.ToString() + "\n");
            int choice = CIO.PromptForInt("Would You Like To Attack? 1. Yes 2. No Please Entre Input: ", 1, 2);
            if (choice == 1)
            {
                int damage = a.Attack();
                a.TakeDamage(damage);
                Console.WriteLine();
                Console.WriteLine(a.GetType().Name + " did " + damage + " points of damage to themself.\n");
                Console.WriteLine(a.ToString() + "\n");
            }
            Run();
        }

        public static StatusPotion StatusGenerator()
        {
            int value = rand.Next(1, 5);
            List<string> Name = new List<string>
            {
                "Strength",
                "Dexterity",
                "Intelligence"
            };
            string name = Name[rand.Next(Name.Count)];
            StatusPotion sp = new StatusPotion(name, value);
            return sp;
        }

        public static Potion HealGenerator()
        {
            int heals = rand.Next(10, 101);
            Potion p = new Potion(heals);
            return p;
        }

        public static Character CharacterCreator()
        {
            int charNum = rand.Next(1, 3);
            int strBase = rand.Next(3, 31);
            int intBase = rand.Next(3, 31);
            int dexBase = rand.Next(3, 31);
            int baseHP = strBase * 10;
            int CurrentHP = rand.Next(1, baseHP);
            if (charNum == 1)
            {
                List<string> Race = new List<string>
                {
                    "Aurin",
                    "Mordesh",
                    "Human",
                    "Elyos",
                    "Dwarf",
                    "Granok"
                };
                string race = Race[rand.Next(Race.Count)];
                Hero c = new Hero(race, DamagerGenerator(), ArmourGenerator(), 0, 0, 0, strBase, intBase, dexBase, CurrentHP, baseHP);
                return c;
            }
            else
            {
                List<string> Race = new List<string>
                {
                    "Asmodian",
                    "Cassian",
                    "Mechari",
                    "Draken",
                    "Chua"
                };
                string race = Race[rand.Next(Race.Count)];
                Monster c = new Monster(race, DamagerGenerator(), ArmourGenerator(), 0, 0, 0, strBase, intBase, dexBase, CurrentHP, baseHP);
                return c;
            }
        }

        public static Weapon DamagerGenerator()
        {
            List<string> Name = new List<string>
            {
                "Krebs Furby",
                "Short Sword",
                "Bo Staff",
                "Nunchucks",
                "Choco Taco",
                "Silver Fork",
                "Golden Fork",
                "Icy Bubble",
                "Love-Me-Knot Chain",
                "Portal Gun",
                "Pop Figure",
                "Left Shoe",
                "Katana",
                "Dagger",
                "Light Sabre",
                "Dagger"
            };
            string name = Name[rand.Next(Name.Count)];
            int value = rand.Next(1, 501);
            int damageMin = rand.Next(1, 100);
            int damageMax = rand.Next(damageMin, 101);
            Weapon w = new Weapon(damageMin, damageMax, name, value);
            return w;
        }

        public static Armour ArmourGenerator()
        {
            List<string> Name = new List<string>
            {
                "Origami Paper",
                "Platemail",
                "Chainmail",
                "Dragonskin",
                "Lizardskin",
                "Leather",
                "Rubber",
                "Cloth",
                "Gold"
            };
            string name = Name[rand.Next(Name.Count)];
            int value = rand.Next(10, 1501);
            int armourRating = rand.Next(8, 18);
            int damageReduction = rand.Next(0, 11);
            int agilityModifier = rand.Next(-6, 0);
            Armour a = new Armour(armourRating, damageReduction, agilityModifier, name, value);
            return a;
        }

        public static Item ItemGen()
        {
            List<string> Name = new List<string>
            {
                "Bucket",
                "Mouse",
                "String",
                "Nickle",
                "Potato",
                "Phone",
                "Taco",
                "Flannel",
                "ID",
                "Polisher",
                "Diamond",
                "CD",
                "Marker",
                "Paper"
            };
            string name = Name[rand.Next(Name.Count)];
            int value = rand.Next(0, 25);
            Item i = new Item(name, value);
            return i;
        }

        public static Good GoodGen()
        {
            List<string> Name = new List<string>
            {
                "Doughnut",
                "Rat Poison",
                "Cashew",
                "Alcohol",
                "Glass Cleaner",
                "Bread",
                "Cake",
                "Paper",
                "Dirt"
            };
            string name = Name[rand.Next(Name.Count)];
            int value = rand.Next(0, 25);
            Good g = new Good(name, value);
            return g;
        }

        public static CharacterCandy CandyGen()
        {
            List<string> Name = new List<string>
            {
                "Penguin",
                "Elf",
                "Human",
                "Aurin",
                "Granok",
                "Mordesh",
                "Dwarf",
                "Pandaren"
            };
            string name = Name[rand.Next(Name.Count)];
            int value = rand.Next(1000, 5000);
            CharacterCandy cC = new CharacterCandy(name, value);
            return cC;
        }
    }
}
