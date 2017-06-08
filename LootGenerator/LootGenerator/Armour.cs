using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    public class Armour : Item
    {

        private int ArmourRating { get; set; }
        private int DamageReduction { get; set; }
        private int AgilityModifier { get; set; }

        public Armour(int armourRating, int damageReduction, int agilityModifier, string name, int value) : base(name, value)
        {
            ArmourRating = armourRating;
            DamageReduction = damageReduction;
            AgilityModifier = agilityModifier;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tArmour Rating: {ArmourRating}\tDamage Reduction: {DamageReduction}\tAgility Modifier: {AgilityModifier}";
        }
    }
}
