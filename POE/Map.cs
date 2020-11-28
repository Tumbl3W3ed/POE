using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    [Serializable()]
    class Map
    {
        private Tile[,] map { get; set; }
        private Hero hero;
        private Enemy[] enemies;
        private Item[] items;
        public int MapWidth;
        public int MapHeight;
        private Random random = new Random();

        public Random Random
        {
            get => random;
            set => random = value;
        }
        public Tile[,] ThisMap
        {
            get => map;
            set => map = value;
        }

        public Hero Hero
        {
            get => hero;
            set => hero = value;
        }

        public Enemy[] Enemies
        {
            get => enemies;
            set => enemies = value;
        }
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyAmount, int AmountOfGoldPicks)
        {
            MapWidth = random.Next(minWidth, maxWidth);
            MapHeight = random.Next(minHeight, maxHeight);
            map = new Tile[MapHeight, MapWidth];
            items = new Item[AmountOfGoldPicks];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = null;
                }
            }
            hero = (Hero)Create(Tile.TileType.Hero);
            map[hero.Y, hero.X] = hero;
            enemies = new Enemy[enemyAmount];
            for (int i = 0; i < enemies.Length; i++)
            {

                enemies[i] = (Enemy)Create(Tile.TileType.Enemy);
                enemies[i].ThisTileType = Tile.TileType.Enemy;
                map[enemies[i].Y, enemies[i].X] = enemies[i];
            }
            for (int i = 0; i < items.Length; i++)
            {

                items[i] = (Item)Create(Tile.TileType.Gold);
                items[i].ThisTileType = Tile.TileType.Gold;
                map[items[i].Y, items[i].X] = items[i];
            }
        }

        private Tile Create(Tile.TileType type)
        {
            int x, y;
            x = random.Next(1, MapWidth - 1);
            y = random.Next(1, MapHeight - 1);
            while (map[y, x] != null)
            {
                x = random.Next(1, MapWidth - 1);
                y = random.Next(1, MapHeight - 1);
            }
            switch (type)
            {
                case Tile.TileType.Hero:
                    return new Hero( y,  x, 40);
                case Tile.TileType.Enemy:
                    if (random.Next(4) > 2)
                    {
                        return new Mage(y, x);
                    }
                    return new Goblin(y, x);
                case Tile.TileType.Gold:
                    return new Gold(y, x);
            }
            return null;
        }

        public Item GetItemAtPosition(int y, int x)
        {
            Item item = null;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    continue;
                }
                if (items[i].X == x && items[i].Y == y)
                {
                    item = items[i];
                    items[i] = null;
                    return item;
                }
            }
            return null;
        }

        public void UpdateVision()
        {
            UpdateCharacterVision(hero);

            foreach (Character c in enemies)
            {
                UpdateCharacterVision(c);
            }
        }

        public void UpdateCharacterVision(Character character)
        {
            character.Vision = new Tile[4]{
                map[character.Y-1, character.X],
                map[character.Y +1, character.X],
                map[character.Y, character.X - 1],
                map[character.Y, character.X+1]
            };
        }
    }
}
