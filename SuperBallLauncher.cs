using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Csharpshooter_ST.Weapons
{
    class SuperBallLauncher : Weapon
    {
        public SuperBallLauncher(PointF location) : base("Images/SuperBallLauncher.png", location)
        {
            this.bulletSpeed = 20f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 700;
        }

        public override Bullet CreateBullet(Soldier s)
        {
            return new Bullet("Images/SuperBall.png", new PointF(), s);
        }
    }
}
