using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    internal class MeleeWeapon : Weapon
    {
        public enum Types { Dagger, LongSword}

        public MeleeWeapon(int damage, int range, int durability, int cost, int weaponType, int x = 0, int y = 0) : base(damage, range, durability, cost, weaponType, x, y)
        {
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
