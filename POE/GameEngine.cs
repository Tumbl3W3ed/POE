using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE
{
    class GameEngine
    {
        private Map map;
        private Shop shop;

        public Map Map
        {
            get => map;
            set => map = value;
        }

        public GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyAmount, int amountOfGoldPickUps)
        {
            map = new Map( minWidth,  maxWidth,  minHeight,  maxHeight,  enemyAmount, amountOfGoldPickUps);
        }

        public void EnemiesMove()
        {
            foreach (var enemy in map.Enemies)
            {
                if (enemy.GetType() != typeof(Goblin))
                {
                    continue;
                }
                bool canMove = false;
                for (int i = 0; i < enemy.Vision.Length; i++)
                {
                    if (enemy.Vision[i] == null)
                    {
                        canMove = true;
                    }
                    if (enemy.Vision[i] != null && enemy.Vision[i].ThisTileType == Tile.TileType.Hero)
                        continue;
                }
                if (!canMove)
                    continue;
                MovePlayer((Character.MovementEnum)map.Random.Next(0, 4) + 1, enemy);
            }
        }

        public bool MovePlayer(Character.MovementEnum direction, Character character)
        {
            if (direction == Character.MovementEnum.Left)
            {
                if (character.X - 1 != 0 && (character.Vision[2] == null || character.Vision[2].ThisTileType == Tile.TileType.Gold))
                {
                    map.ThisMap[character.Y, character.X] = null;
                    character.Move(Character.MovementEnum.Left);
                    map.ThisMap[character.Y, character.X] = character;
                    character.Pickup(map.GetItemAtPosition(character.Y, character.X));
                    return true;
                }
            }
            else if (direction == Character.MovementEnum.Right)
            {
                if (character.X + 2 != map.MapWidth && (character.Vision[3] == null || character.Vision[3].ThisTileType == Tile.TileType.Gold))
                {
                    map.ThisMap[character.Y, character.X] = null;
                    character.Move(Character.MovementEnum.Right);
                    map.ThisMap[character.Y, character.X] = character;
                    character.Pickup(map.GetItemAtPosition(character.Y, character.X));
                    return true;
                }
            }
            else if (direction == Character.MovementEnum.Up)
            {
                if (character.Y - 1 != 0 && (character.Vision[0] == null || character.Vision[0].ThisTileType == Tile.TileType.Gold))
                {
                    map.ThisMap[character.Y, character.X] = null;
                    character.Move(Character.MovementEnum.Up);
                    map.ThisMap[character.Y, character.X] = character;
                    character.Pickup(map.GetItemAtPosition(character.Y, character.X));
                    return true;
                }
            }
            else
            {
                if (character.Y + 2 != map.MapHeight && (character.Vision[1] == null || character.Vision[1].ThisTileType == Tile.TileType.Gold))
                {
                    map.ThisMap[character.Y, character.X] = null;
                    character.Move(Character.MovementEnum.Down);
                    map.ThisMap[character.Y, character.X] = character;
                    character.Pickup(map.GetItemAtPosition(character.Y, character.X));
                    return true;
                }
            }
            return false;
        }

        public void EnemyAttacks()
        {
            foreach (var enemy in map.Enemies)
            {
                if (enemy.CheckRange(map.Hero))
                {
                    enemy.Attack(map.Hero);
                }
                foreach (var e in map.Enemies)
                {
                    if (e == enemy)
                    {
                        continue;
                    }
                    if (enemy.CheckRange(e))
                    {
                        enemy.Attack(e);
                    }
                }
            }
        }
    }
}
