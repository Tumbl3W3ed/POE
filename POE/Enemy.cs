using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    [System.Serializable()]
    abstract class Enemy : Character
    {
        protected Random random = new Random();
        public Enemy(int y, int x, int maxHp, int Damage, char symbol, Weapon weapon) : base(y, x, maxHp, Damage, symbol, weapon)
        {

        }

        public override string ToString()
        {
            return nameof(Enemy) + "at [" + this.X + "," + this.Y + "] with (" + this.hp + ") hp";
        }
    }
}
