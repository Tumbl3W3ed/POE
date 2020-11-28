using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{   
    abstract class Weapon : Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected int weaponType;
        public int Damage { get => damage; set => damage = value; }
        public virtual int Range { get => range; set => range = value; }
        public int Durability { get => durability; set => durability = value; }
        public int Cost { get => cost; set => cost = value; }
        public int WeaponType { get => weaponType; set => weaponType = value; }

        public Weapon(int damage, int range, int durability, int cost, int weaponType, int x = 0, int y = 0)  : base(y,x)
        {
            this.damage = damage;
            this.range = range;
            this.durability = durability;
            this.cost = cost;
            this.weaponType = weaponType;
        }
    }
}
