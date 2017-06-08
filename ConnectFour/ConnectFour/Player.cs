using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Player
    {

        private string Name;
        private bool IsComp;

        public Player(string name, bool isComp)
        {
            Name = name;
            IsComp = isComp;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
