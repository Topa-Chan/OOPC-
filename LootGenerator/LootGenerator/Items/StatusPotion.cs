using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenerator.Characters;
using LootGenerator.Interfaces;

namespace LootGenerator.Items
{
    public class StatusPotion : Item, IConsumable
    {

        private string Name;
        private int Value;

        public StatusPotion(string name, int value) : base(name, value)
        {
            Name = name;
            Value = value;
        }

        public string GetDescription()
        {
            return $"This potion gives the character a {Name} bonus of {Value}.";
        }

        public void Use(Character character)
        {
            int status;
            if (Name == "Strength")
            {
                status = 1;
            } else if (Name == "Dexterity")
            {
                status = 2;
            } else
            {
                status = 3;
            }
            character.Satus(Value, status);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tDescription: {GetDescription()}";
        }
    }
}
