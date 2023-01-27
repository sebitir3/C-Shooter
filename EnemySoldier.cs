using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace Csharpshooter_ST
{
    public class EnemySoldier : Soldier
    {
        int directionChange = 0;
        int nextDirectionChange = 0;
        public EnemySoldier(PointF location) : base("Images/Enemy1.png", location) 
        { 
            MainForm.enemyList.Add(this); 
            isFiring = true;
            moveSpeed = 2;
            walkDirc = 1;

            Random r = new Random((int)location.X);
            nextDirectionChange = r.Next(1000) + 1000;

            this.currentWeapon = new Weapons.EnemyPistol(this.location);
        }

        public override void Update(int time)
        {
            base.Update(time);
            directionChange += time;

            if(directionChange >= nextDirectionChange)
            {
                Random r = new Random();
                facingAngle = r.Next(360);
                directionChange = 0;
                nextDirectionChange = r.Next(1000) + 1000;
            }

            if (this.dead)
                MainForm.enemyList.Remove(this);

           

            
        }

















    }
}
