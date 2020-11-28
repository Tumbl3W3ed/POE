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
        public Tile leadersTarget { get => LeadersTarget; set => LeadersTarget = value; }
        public Leader(int y, int x, Tile target) : base(y, x, 20, 2, 'L', new MeleeWeapon(MeleeWeapon.Types.LongSword))
        {
            leadersTarget = target;

        }



        public override MovementEnum ReturnMove(MovementEnum move)
        {
            if (LeadersTarget.X > x)
            {
                if (vision[3] == null || vision[3]?.GetType() != typeof(Character) && vision[3]?.ThisTileType != TileType.Empty)
                {
                    return MovementEnum.Right;
                }
            }
            if (LeadersTarget.X < x)
            {
                if (vision[2] == null || vision[2]?.GetType() != typeof(Character) && vision[2]?.ThisTileType != TileType.Empty)
                {
                    return MovementEnum.Left;
                }
            }
            if (LeadersTarget.Y > y)
            {
                if (vision[0] == null || vision[0]?.GetType() != typeof(Character) && vision[0]?.ThisTileType != TileType.Empty)
                {
                    return MovementEnum.Up;
                }
            }
            if (LeadersTarget.Y < y)
            {
                if (vision[1] == null || vision[1]?.GetType() != typeof(Character) && vision[1]?.ThisTileType !=TileType.Empty)
                {
                    return MovementEnum.Down;
                }
            }

            bool canmove = false;
            int direction = random.Next(0, 4);
            for (int i = 0; i < vision.Length; i++)
            {
                if (vision[i] == null)
                {
                    canmove = true;
                    break;
                }
                if (vision[i].GetType() != typeof(Character) && vision[i]?.ThisTileType != TileType.Empty)
                {
                    canmove = true;
                    break;
                }
            }
            if (canmove == false)
            {
                return MovementEnum.NoMovement;
            }
            while (vision[direction] != null)
            {
                if (vision[direction].GetType() != typeof(Character) && vision[direction]?.ThisTileType != TileType.Empty)
                {
                    return (MovementEnum)direction + 1;
                }
                direction = random.Next(0, 4);
            }
            return (MovementEnum)direction + 1;
        }
    }
}
