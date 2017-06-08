using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenerator.Characters;

namespace LootGenerator.Interfaces
{
    public interface IConsumable
    {

        void Use(Character character);
        string GetDescription();

    }
}
