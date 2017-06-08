using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator.Characters
{
    public class Hero : Character
    {
        private string Race;
        private Weapon EquippedWeapon;
        private Armour EquippedArmour;

        public Hero(string race, Weapon equippedWeapon, Armour equippedArmour, int strMod, int intMod, int dexMod, int strBase, int intBase, int dexBase, int currentHP, int baseHP) : base(strMod, intMod, dexMod, strBase, intBase, dexBase, currentHP, baseHP)
        {     
            Race = race;
            EquippedWeapon = equippedWeapon;
            EquippedArmour = equippedArmour;
        }
        
        public override int Attack()
        {
            int damage = rand.Next(EquippedWeapon.DamageMin, EquippedWeapon.DamageMax + 1);
            return damage;
        }

        public override int TakeDamage(int damage)
        {
            CurrentHP -= damage;
            if (CurrentHP < 0)
            {
                CurrentHP = 0;
            }
            return CurrentHP;
        }

        public override int Heal(int healamount)
        {
            CurrentHP += healamount;
            if (CurrentHP > baseHP)
            {
                CurrentHP = baseHP;
            }
            return CurrentHP;
        }

        public override int Satus(int value, int status)
        {
            if (status == 1)
            {
                strMod = value;
                return strMod;
            }
            else if (status == 2)
            {
                dexMod = value;
                return dexMod;
            }
            else
            {
                intMod = value;
                return intMod;
            }
        }

        public override string Changing(string name)
        {
            Race = name;
            return Race;
        }

        public override string ToString()
        {
            return $"Race: {Race}\nEquipped Weapon: {EquippedWeapon}\nEquipped Armour: {EquippedArmour}\n{base.ToString()}";
        }
    }
}
