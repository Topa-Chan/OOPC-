using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenerator.Characters;
using LootGenerator.Interfaces;

namespace LootGenerator.Items
{
    public class CharacterCandy : Item, IConsumable
    {

        private string Name;
        private int Value;

        public CharacterCandy(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string GetDescription()
        {
            return "This candy changes the character into a " + Name + ".";
        }

        public void Use(Character character)
        {
            character.Changing(Name);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n{GetDescription()}";
        }
    }
}
