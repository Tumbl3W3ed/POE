namespace POE
{
    class Mage : Enemy
    {
        public Mage(int y, int x) : base(y, x, 10, 2, 'M')
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return MovementEnum.NoMovement;
        }

        public override bool CheckRange(Character target)
        {
            if (this == target)
                return false;
            if (target.X == this.X || target.X == this.X - 1 || target.X == this.X + 1)
            {
                if (target.Y == this.Y || target.Y == this.Y - 1 || target.Y == this.Y + 1)
                    return true;
            }
            return false;
        }
    }
}
