namespace POE
{
    [System.Serializable()]
    abstract class Item : Tile
    {
        protected Item(int y, int x) : base(y, x)
        {
        }

        public abstract string ToString();
    }
}
