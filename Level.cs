using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Csharpshooter_ST
{
    public class Level
    {
        public static void initializeLists()
        {
            MainForm.enemyList = new List<Soldier>();
            MainForm.bulletList = new List<Bullet>();
            MainForm.wallList = new List<Wall>();
            MainForm.explosionList = new List<Weapons.Explosion>();

        }

        public static void createBorders(int topX, int topY, int width, int height)
        {
            Wall borderTop = new Wall("Blue", topX - 80, topY - 80, width + 80, 80);
            Wall borderLeft = new Wall("Blue", topX - 80, topY, 80, height + 80);
            Wall borderBottom = new Wall("Blue", topX, topY + height, width + 80, 80);
            Wall borderRight = new Wall("Blue", topX + width, topY - 80, 80, height + 80);
        }

        public static void createWalls()
        {
            Wall wall1 = new Wall("Blue", 150, 250, 300, 30);
            Wall wall2 = new Wall("Blue", 150, 250, 30, 300);
            Wall wall3 = new Wall("Blue", 400, 250, 300, 30);
            Wall wall4 = new Wall("Blue", 150, 500, 30, 300);
            Wall wall5 = new Wall("Blue", 150, 250, 300, 30);
        }

        public static void createEnemies()
        {
            EnemySoldier e1 = new EnemySoldier(new Point(400, 450));
            EnemySoldier e2 = new EnemySoldier(new Point(400, 500));
            EnemySoldier e3 = new EnemySoldier(new Point(400, 550));
            EnemySoldier e4 = new EnemySoldier(new Point(400, 600));
        }

        public static void createLevel()
        {
            MainForm.player1 = new Player(new PointF(400, 400));

            initializeLists();
            createBorders(-800, -800, 1600, 1600);
            createWalls();
            createEnemies();
        }
    }
}
