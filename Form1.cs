using Csharpshooter_ST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharpshooter_ST
{
    public partial class MainForm : Form
    {
        public static Player player1;
        EnemySoldier enemy1;
        public static List<Bullet> bulletList;
        public static List<Soldier> enemyList;
        public static List<Wall> wallList;
        public static List<Weapons.Explosion> explosionList;
        Graphics windowsGraphics;
        Graphics onScreenGraphics;
        public static Bitmap screen;

        public Picture gameOverScreen;
        public Picture victoryScreen;

        public static Point viewOffset;

        public Weapon currentWeapon;


        public MainForm()
        {
            InitializeComponent();
            GameTimer.Start();
            GameTimer.Enabled = false;
            windowsGraphics = this.CreateGraphics();
            screen = new Bitmap(this.Width, this.Height);
            onScreenGraphics = Graphics.FromImage(screen);

            this.Paint += new PaintEventHandler(DrawGame);
            Init();
        }


        void Init()
        {
            Level.createLevel();

            gameOverScreen = new Picture("Images/GameOver.png", new PointF(this.Width / 2, this.Height / 3), 1, 1);
            victoryScreen = new Picture("Images/Victory.png", new PointF(this.Width / 2, this.Height / 3), 1, 1);


            this.KeyDown += new System.Windows.Forms.KeyEventHandler(player1.KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(player1.KeyUp);



        }


        public void DrawGame(Object sender, PaintEventArgs e)
        {
            if (!GameTimer.Enabled)
            {
                return;
            }
                

            onScreenGraphics.Clear(Color.Black);
            player1.Draw(onScreenGraphics);


            foreach (Bullet b in bulletList)
            {
                b.Draw(onScreenGraphics);
            }

            foreach (Soldier s in enemyList)
            {
                s.Draw(onScreenGraphics);
            }

            foreach (Wall w in wallList)
            {
                w.Draw(onScreenGraphics);
            }

            foreach (Weapons.Explosion explode in explosionList)
            {
                explode.Draw(onScreenGraphics);
            }

            if (player1.dead)
                gameOverScreen.Draw(onScreenGraphics);

            if (enemyList.Count <= 0)
                victoryScreen.Draw(onScreenGraphics);

            windowsGraphics.DrawImage(screen, new Point(0, 0));

        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            player1.Update(GameTimer.Interval);

            for (int i = 0; i < bulletList.Count; i++)
            {
                bulletList[i].Update(GameTimer.Interval);
            }


            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Update(GameTimer.Interval);
            }

            for (int i = 0; i < explosionList.Count; i++)
            {
                explosionList[i].Update(GameTimer.Interval);
            }

            //set the view offset to be equal to the the top left corner of the camera/view
            // our player is in the center of our camera

            viewOffset.X = (int)player1.location.X - this.Width / 2;
            viewOffset.Y = (int)player1.location.Y - this.Height / 2;

            OnPaint(new PaintEventArgs(windowsGraphics, new Rectangle(0, 0, this.Width, this.Height)));

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void pistolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new Weapons.EnemyPistol(player1.location); 
        }

        private void barret50CalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new Weapons.SniperRifle(player1.location);

        }

        private void minigunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new Weapons.Railgun(player1.location);

        }

        private void superBallLaucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new Weapons.SuperBallLauncher(player1.location);
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.moveSpeed = 10;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.moveSpeed = 20;
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.moveSpeed = 30;
        }

        private void clippingThroughWallsFastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.moveSpeed = 9001;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Init();
            GameTimer.Enabled = true;
            title.Hide();
            play.Hide();
        }
    }

}
