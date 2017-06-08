using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenerator.Characters;
using LootGenerator.Interfaces;

namespace LootGenerator
{
    public class Potion : Item, IConsumable
    {
        private int HealAmount { get; set; }

        public Potion(int healAmount) : base("Health Potion", (healAmount/10))
        {
            HealAmount = healAmount;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tHP: {HealAmount} Description: {GetDescription()}";
        }

        public void Use(Character character)
        {
            character.Heal(HealAmount);
        }

        public string GetDescription()
        {
            return "This potion heals the character " + HealAmount + "HP.";
        }
    }
}
