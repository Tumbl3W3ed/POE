namespace POE
{
    [System.Serializable()]
    class Goblin : Enemy
    {
        public Goblin(int y, int x) : base(y, x, 10, 1, 'G', new MeleeWeapon(MeleeWeapon.Types.Dagger))
        {
            purse = 1;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
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

        public override string ToString()
        {
            return (weapon != null ? "Equipped: " : "BareHanded: ")+"Goblin"+base.ToString();
        }
    }
}
