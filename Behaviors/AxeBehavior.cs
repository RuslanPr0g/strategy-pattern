using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class AxeBehavior : WeaponBehavior
    {
        public string UseWeapon()
        {
            return "Hghhrrr!!! I have an axe!";
        }
    }
}
