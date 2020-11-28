namespace POE
{
    [System.Serializable()]
    class Hero : Character
    {

        public Hero(int y, int x, int maxhp) : base(y, x, maxhp, 2, 'H')
        {
            this.ThisTileType = TileType.Hero;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return move;
        }

        public override string ToString()
        {
            return "Player Stats:\n" + "HP: " + hp + "/" + maxHP + "\nGold: " + purse + "\nDamage: 2\n" + "[" + Y + "," + X + "]";
        }
    }
}
