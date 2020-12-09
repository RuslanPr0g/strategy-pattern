using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class KnifeBehavior : WeaponBehavior
    {
        public string UseWeapon()
        {
            return "This knife is so small, I can't attack anyone!";
        }
    }
}
