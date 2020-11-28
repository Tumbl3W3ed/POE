using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    [Serializable()]
    class Leader : Enemy
    {
        private Tile LeadersTarget;
        public Tile leadersTarget { get => LeadersTarget; set => LeadersTarget = value; }
        public Leader(int y, int x, Tile target) : base(y, x, 20, 2, 'L', new MeleeWeapon(MeleeWeapon.Types.LongSword))
        {
            leadersTarget = target;
            purse = 2;
        }



        public override MovementEnum ReturnMove(MovementEnum move)
        {
            foreach (var item in vision)
            {
                if (item != null)
                    if (item.ThisTileType == TileType.Hero)
                        return MovementEnum.NoMovement;
            }
            if (LeadersTarget.X > x)
            {
                if (vision[3] == null || (vision[3].GetType().BaseType != typeof(Character) && vision[3].GetType().BaseType.BaseType != typeof(Character) && vision[3].ThisTileType != TileType.Empty))
                {
                    return MovementEnum.Right;
                }
            }
            if (LeadersTarget.X < x)
            {
                if (vision[2] == null || (vision[2].GetType().BaseType != typeof(Character) && vision[2].GetType().BaseType.BaseType != typeof(Character) && vision[2].ThisTileType != TileType.Empty))
                {
                    return MovementEnum.Left;
                }
            }
            if (LeadersTarget.Y > y)
            {
                if (vision[0] == null || (vision[0].GetType().BaseType != typeof(Character) && vision[0].GetType().BaseType.BaseType != typeof(Character) && vision[0].ThisTileType != TileType.Empty))
                {
                    return MovementEnum.Down;
                }
            }
            if (LeadersTarget.Y < y)
            {
                if (vision[1] == null || (vision[1].GetType().BaseType != typeof(Character) && vision[1].GetType().BaseType.BaseType != typeof(Character) && vision[1].ThisTileType != TileType.Empty))
                {
                    return MovementEnum.Up;
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
                if (vision[i].GetType().BaseType != typeof(Character) && vision[i]?.GetType().BaseType.BaseType != typeof(Character) && vision[i]?.ThisTileType != TileType.Empty)
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
                if (vision[direction].GetType().BaseType != typeof(Character) && vision[direction]?.GetType().BaseType.BaseType != typeof(Character) && vision[direction]?.ThisTileType != TileType.Empty)
                {
                    return (MovementEnum)direction + 1;
                }
                direction = random.Next(0, 4);
            }
            return (MovementEnum)direction + 1;
        }

        public override string ToString()
        {
            return (weapon != null ? "Equipped: " : "BareHanded: ") + "Leader" + base.ToString();
        }
    }
}
