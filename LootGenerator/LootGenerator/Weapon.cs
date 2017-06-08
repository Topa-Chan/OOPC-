using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    public class Weapon : Item
    {
        public int DamageMin { get; } //set; }
        public int DamageMax { get; } //set; }
        

        public Weapon(int damageMin, int damageMax, string name, int value) : base(name, value)
        {
            DamageMin = damageMin;
            DamageMax = damageMax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tDamage: {DamageMin}-{DamageMax}";
        }
    }
}
