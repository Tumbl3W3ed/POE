using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POE
{
    public partial class FrmGameView : Form
    {
        GameEngine gameEngine;
        FileRead fileRead = new FileRead();
        FileWrite fileWrite = new FileWrite();
        public FrmGameView()
        {
            InitializeComponent();
            gameEngine = new GameEngine(6, 8, 6, 8, 5, 4,2);
            updateMap();
            lblCombat.Text = "Combat Information:";
        }

        public void Save()
        {
            fileWrite.WriteData<Map>(gameEngine.Map);
        }
        public void updateMap()
        {
            string mapResult = "";
            const int padWidth = 5;
            for (int y = 0; y < gameEngine.Map.ThisMap.GetLength(0); y++)
            {
                for (int x = 0; x < gameEngine.Map.ThisMap.GetLength(1); x++)
                {
                    if (y == 0 || x == 0 || y == gameEngine.Map.ThisMap.GetLength(0) - 1 || x == gameEngine.Map.ThisMap.GetLength(1) - 1)
                    {

                       mapResult += $"{"X",padWidth}";
                    }
                    else if (gameEngine.Map.ThisMap[y, x] == null)
                    {
                        mapResult += $"{".",padWidth}";
                    }
                    else
                    {
                        if (gameEngine.Map.ThisMap[y, x].ThisTileType == Tile.TileType.Gold)
                        {
                            mapResult += $"{"g",padWidth}";
                        }else if (gameEngine.Map.ThisMap[y, x].ThisTileType == Tile.TileType.Weapon)
                        {
                            mapResult += $"{"w",padWidth}";
                        }
                        else
                            mapResult += $"{((Character)gameEngine.Map.ThisMap[y, x]).Symbol,padWidth}";

                    }
                }
                mapResult += "\n\n";
            }
            LblMap.Text = mapResult;
            UpdateHeroStats();
            updateAttackTargets();
            updateEnemyStats();
        }

        private void updateEnemyStats()
        {
            string output = "";
            foreach (var enemy in gameEngine.Map.Enemies)
            {
                output += enemy.ToString() + "\n";
            }
            
            if (gameEngine.Map.Hero.Hp <= 0)
            {
                output = "Enemies Win";
            }
            if(gameEngine.Map.Enemies.Length==0 && gameEngine.Map.Hero.Hp > 0)
            {
                output = "YOU WIN!! nice...";
            }
            lblEnemyData.Text = "Enemy Data:\n" + output;
        }

        private void UpdateHeroStats()
        {
            if (gameEngine.Map.Hero.Hp <= 0)
            {
                LblPlayerStats.Text = "You Lose";
            }
            LblPlayerStats.Text = gameEngine.Map.Hero.ToString();
        }

        private void Attack(Character target)
        {
            gameEngine.Map.Hero.Attack(target);
            lblCombat.Text = "Combat Information:\n" + ((Enemy)target).ToString();
            if (target.IsDead())
            {
                lblCombat.Text = "Combat Information:";
                
                gameEngine.Map.ThisMap[target.Y, target.X] = null;
            }
            gameEngine.EnemyAttacks();
            RemoveEnemies();
            updateMap();
        }

        private void RemoveEnemies()
        {
            for (int i = 0; i < gameEngine.Map.Enemies.Length; i++)
            {
                if (gameEngine.Map.Enemies[i].IsDead())
                {
                    gameEngine.Map.ThisMap[gameEngine.Map.Enemies[i].Y, gameEngine.Map.Enemies[i].X] = null;
                    gameEngine.Map.Enemies[i] = null;
                }
            }
            gameEngine.Map.Enemies = gameEngine.Map.Enemies.Where(thisClass => thisClass != null).ToArray();
        }

        private void updateAttackTargets()
        {
            gameEngine.Map.UpdateVision();
            btnAttackUp.Enabled = false;
            btnAttackDown.Enabled = false;
            btnAttackRight.Enabled = false;
            btnAttackLeft.Enabled = false;
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Up - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Up - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackUp.Enabled = true;
                }
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Down - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Down - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackDown.Enabled = true;
                }
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Left - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Left - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackLeft.Enabled = true;
                }
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Right - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Right - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackRight.Enabled = true;
                }
            
        }

        private void BtnAttackUp_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Up - 1]);
        }

        private void BtnAttackDown_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Down - 1]);
        }

        private void BtnAttackLeft_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Left - 1]);
        }

        private void BtnAttackRight_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Right - 1]);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Up, gameEngine.Map.Hero))
            {
                MovePlayer();
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Down, gameEngine.Map.Hero))
            {
                MovePlayer();
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Left, gameEngine.Map.Hero))
            {
                MovePlayer();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Right, gameEngine.Map.Hero))
            {
                MovePlayer();
                  
            }
        }

        private void MovePlayer()
        {
            gameEngine.Map.UpdateVision();
            gameEngine.EnemiesMove();
            RemoveEnemies();
            gameEngine.EnemyAttacks();
            updateMap();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile()
        {
            gameEngine.Map = (Map)fileRead.ReadData<Map>();
            updateMap();
        }
    }
}
