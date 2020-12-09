using StrategyPattern.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Knight : Character
    {
        public Knight()
        {
            this.weaponBehavior = new SwordBehavior();
        }
    }
}
