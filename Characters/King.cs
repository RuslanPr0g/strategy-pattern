using StrategyPattern.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class King : Character
    {
        public King()
        {
            this.weaponBehavior = new KnifeBehavior();
        }
    }
}
