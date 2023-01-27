using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Csharpshooter_ST.Weapons
{
    class SniperRifle : Weapon
    {
        public SniperRifle(PointF location) : base("Images/SniperRifle.png", location)
        {
            this.bulletSpeed = 50f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 1000;
        }

        public override Bullet CreateBullet(Soldier s)
        {
            return new Bullet("Images/SniperBullet.png", new PointF(), s);
        }
    }
}
