using StrategyPattern.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Character
    {
        protected WeaponBehavior weaponBehavior;

        public string Fight()
        {
            return this.weaponBehavior.UseWeapon();
        }

        public void SetWeapon(WeaponBehavior w)
        {
            this.weaponBehavior = w;
        }
    }
}
