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
            int direction = random.Next(0, 5);
            while (vision[direction] != null)
            {
                direction = random.Next(0, 5);
            }
            return (MovementEnum)direction;
        }
    }
}
