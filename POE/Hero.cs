namespace POE
{
    [System.Serializable()]
    class Hero : Character
    {

        public Hero(int y, int x, int maxhp) : base(y, x, maxhp, 2, 'H',null)
        {
            this.ThisTileType = TileType.Hero;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return move;
        }

        public override string ToString()
        {
            return "Player Stats:\n" + "HP: " + hp + "/" + maxHP
                + "\nCurrent Weapon: " + (weapon != null ? weapon.WeaponType : "Bare Hands")
                + "\n Weapon Range: " + (weapon != null ? weapon.Range.ToString() : "1")
                + "\n Weapon Damage: " + (weapon != null ? weapon.Damage.ToString() : "2")
                + "\nGold: " + purse
                + "\nDamage: 2\n"
                + "[" + Y + "," + X + "]";
        }
    }
}
