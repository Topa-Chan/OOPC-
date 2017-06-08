using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenerator.Characters;
using LootGenerator.Interfaces;

namespace LootGenerator.Items
{
    public class Good : Item, IConsumable
    {

        private string Name;
        private int Value;

        public Good(string name, int value) : base(name, value)
        {
            Name = name;
            Value = value;
        }

        public string GetDescription()
        {
            return "This item is a consumable that may give a character a health heal.";
        }

        public void Use(Character character)
        {
            Random rand = new Random();
            int heal = rand.Next(0, 2);
            if (heal == 0)
            {
                int healamount = rand.Next(1, 25);
                character.Heal(healamount);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n{GetDescription()}";
        }

    }
}
