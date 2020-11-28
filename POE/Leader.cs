using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Leader : Enemy
    {
        private Tile LeadersTarget;
        public Tile LeadersTarget1 { get => LeadersTarget; set => LeadersTarget = value; }
        public Leader(int y, int x) : base(y, x, 20, 2, 'L')
        {
        }



        public override MovementEnum ReturnMove(MovementEnum move)
        {
            if (LeadersTarget.X > x)
            {
                if (vision[3] == null)
                {
                    return MovementEnum.Right;
                }
            }
            if (LeadersTarget.X < x)
            {
                if (vision[2] == null)
                {
                    return MovementEnum.Left;
                }
            }
            if (LeadersTarget.Y > y)
            {
                if (vision[0] == null)
                {
                    return MovementEnum.Up;
                }
            }
            if (LeadersTarget.Y < y)
            {
                if (vision[1] == null)
                {
                    return MovementEnum.Down;
                }
            }

            bool canmove = false;
            int direction = random.Next(1, 5);
            for (int i = 0; i < vision.Length; i++)
            {
                if (vision[i] == null)
                {
                    canmove=true;
                    break;
                }
            }
            if(canmove == false)
            {
                return MovementEnum.NoMovement;
            }
            while (vision[direction] != null)
            {
                direction = random.Next(1, 5);
            }
            return (MovementEnum)direction;
        }
    }
}
