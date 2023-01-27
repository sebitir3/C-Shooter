using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Csharpshooter_ST
{
    public class Player : Soldier
    {
       
        public Player(PointF location):base("Images/Player.png", location) { this.currentWeapon = new Weapons.SuperBallLauncher(this.location); }
        

        public void KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) 
                turnDirc = 0.2f;
            if (e.KeyCode == Keys.D)
                turnDirc = -0.2f;

            if (e.KeyCode == Keys.W)
                walkDirc = 1;
            if (e.KeyCode == Keys.S)
                walkDirc = -1;

            if (e.KeyCode == Keys.Space)
                isFiring = true;

            
        }

        public void KeyUp(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                turnDirc = 0;
            if (e.KeyCode == Keys.D)
                turnDirc = 0;
            if (e.KeyCode == Keys.W)
                walkDirc = 0;
            if (e.KeyCode == Keys.S)
                walkDirc = 0;
            if (e.KeyCode == Keys.Space)
                isFiring = false;
        }
    
        




    }


}
