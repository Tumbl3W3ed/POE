namespace POE
{
    [System.Serializable()]
    class Goblin : Enemy
    {
        public Goblin(int y, int x) : base(y, x, 10, 1, 'G')
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            bool canmove = false;
            int direction = random.Next(1, 5);
            for (int i = 0; i < vision.Length; i++)
            {
                if (vision[i] == null)
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
                direction = random.Next(1, 5);
            }
            return (MovementEnum)direction;
        }
    }
}
