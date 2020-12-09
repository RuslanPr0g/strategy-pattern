using StrategyPattern.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Troll : Character
    {
        public Troll()
        {
            this.weaponBehavior = new AxeBehavior();
        }
    }
}
