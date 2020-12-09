using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class BowAndArrowBehavior : WeaponBehavior
    {
        public string UseWeapon()
        {
            return "How many arrows do I need to kill those five trolls?";
        }
    }
}
