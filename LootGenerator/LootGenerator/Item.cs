using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    public class Item
    {

        private string Name { get; set; }
        private int Value { get; set; }

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name}\tName: {Name}\tValue: {Value} gold pieces";
        }
    }
}
