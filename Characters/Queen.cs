using StrategyPattern.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Queen : Character
    {
        public Queen()
        {
            this.weaponBehavior = new BowAndArrowBehavior();
        }
    }
}
