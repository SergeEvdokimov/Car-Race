using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class Form1 : Form
    {
        Random random;
        int collectedCoins;
        PictureBox[] roadlines;
        PictureBox[] enemys;
        PictureBox[] coins;
        private void init_game()
        {
            collectedCoins = 0;
            new Settings();
            roadlines = new PictureBox[] { pbRoadLine1, pbRoadLine2, pbRoadLine3, pbRoadLine4 };
            enemys = new PictureBox[] { Enemy1, Enemy2, Enemy3 };
            coins = new PictureBox[] { Coin1, Coin2, Coin3, Coin4 };
            random = new Random();
            gen_start_pos();
            lblGameOver.Visible = false;
            GameTimer.Interval = 1000 / Settings.TimerSpeed;
            GameTimer.Start();
        }
        private void move_coins()
        {
            int x;
            for (int i = 0; i < coins.Length; i++)
            {

                if (coins[i].Top >= this.Height)
                {
                    x = random.Next(pbBondLeft.Right, pbBondRight.Left);
                    coins[i].Location = new Point(x, -coins[i].Height);
                }
                else
                {
                    coins[i].Top += (int)Settings.GameSpeed;
                }
            }
        }
        private void move_enemys()
        {
            int x;
            for (int i = 0; i < enemys.Length; i++)
            {

                if (enemys[i].Top >= this.Height)
                {
                    x = random.Next(pbBondLeft.Right, pbBondRight.Left);
                    enemys[i].Location = new Point(x, -enemys[i].Height);
                }
                else
                {
                    enemys[i].Top += (int)Settings.GameSpeed;
                }
            }
        }
        private void move_lines()
        {
            for (int i = 0; i < roadlines.Length; i++)
            {
                if (roadlines[i].Top >= this.Height)
                {
                    roadlines[i].Top = -roadlines[i].Height;
                }
                else
                {
                    roadlines[i].Top += (int)Settings.GameSpeed;
                }
            }
        }
        private void is_game_over()
        {
           for(int i = 0; i < enemys.Length; i ++)
            {
               if( Car.Bounds.IntersectsWith(enemys[i].Bounds))
               {
                    Settings.IsGameOver = true;
               }
           }
        }
        private void is_get_coins()
        {
            int x;
            for (int i = 0; i <coins.Length; i ++)
            {
                if(Car.Bounds.IntersectsWith(coins[i].Bounds))
                {
                    collectedCoins++;
                    x = random.Next(pbBondLeft.Right, pbBondRight.Left);
                    coins[i].Location = new Point(x, -coins[i].Height);
                    Settings.MinSpeed += 0.5f;
                    Settings.MaxSpeed += 0.5f;
                    Settings.GameSpeed += 0.5f;
                }
            }
            lblCoins.Text = "Монет :" + collectedCoins.ToString();
        }
        private void game_over_actios()
        {
            GameTimer.Stop();
            lblGameOver.Visible = true;
            Car.Image = Properties.Resources.explosion;
            DialogResult dialogResult = MessageBox.Show("Ваш счет : " + collectedCoins.ToString()
            + "\nИграть заново?", "\nИгра окончена! :(", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Car.Image = Properties.Resources.car;
                init_game();
            }
            else
            {
                this.Close();
            }
        }
        private void gen_start_pos()
        {
            int startY = -Enemy1.Height;
            int x;
            for(int i = 0; i < enemys.Length; i ++)
            {
                x = random.Next(pbBondLeft.Right, pbBondRight.Left);
                enemys[i].Location = new Point(x,startY);
                startY -= this.Height / enemys.Length;
            }
        }
        public Form1()
        {
            InitializeComponent();
            init_game();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            move_lines();
            move_enemys();
            move_coins();
            is_get_coins();
            if (Settings.IsGameOver)
            {
                game_over_actios();
            }
            is_game_over();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Settings.IsGameOver)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (Car.Left > pbBondLeft.Right)
                        {
                            Car.Left -= Settings.CarTurnSpeed;
                        }
                        break;
                    case Keys.Right:
                        if (Car.Right < pbBondRight.Left)
                        {
                            Car.Left += Settings.CarTurnSpeed;
                        }
                        break;
                    case Keys.Up:
                        if (Settings.GameSpeed < Settings.MaxSpeed)
                        {
                            Settings.GameSpeed++;
                        }
                        break;
                    case Keys.Down:
                        if (Settings.GameSpeed < Settings.MinSpeed)
                        {
                            Settings.GameSpeed--;
                        }
                        break;
                }
            }
        }
    }
}
