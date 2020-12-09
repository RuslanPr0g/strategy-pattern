using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class SwordBehavior : WeaponBehavior
    {
        public string UseWeapon()
        {
            return "I will kill you using this sword!";
        }
    }
}
