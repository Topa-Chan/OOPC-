using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator.Characters
{
    public abstract class Character
    {

        public int Strength { get; }
        public int Intelligence { get; }
        public int Dexterity { get; }

        public static Random rand = new Random();
        protected int strBase;
        protected int intBase;
        protected int dexBase;
        protected int strMod = 0;
        protected int intMod = 0;
        protected int dexMod = 0;
        protected int baseHP;
        protected int CurrentHP;
        protected Weapon equippedWeapon;
        protected Armour equippedArmour;

        public Character(int strMod, int intMod, int dexMod, int strBase, int intBase, int dexBase, int currentHP, int baseHP)
        {
            this.strMod = strMod;
            this.intMod = intMod;
            this.dexMod = dexMod;
            this.strBase = strBase;
            this.intBase = intBase;
            this.dexBase = dexBase;
            CurrentHP = currentHP;
            Strength = strBase + strMod;
            this.baseHP = baseHP;
            Intelligence = intBase + intMod;
            Dexterity = dexBase + dexMod;
        }

        public abstract int Attack();

        public abstract int TakeDamage(int damage);

        public abstract int Heal(int healamount);

        public abstract int Satus(int satus, int value);

        public abstract string Changing(string name);

        public override string ToString()
        {
            return $"HP: {CurrentHP}/{baseHP}\tStrength: {(Strength + strMod)}\tIntelligence: {(Intelligence + intMod)}\tDexterity: {(Dexterity + dexMod)}\n";
        }

    }
}
