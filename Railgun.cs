using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Csharpshooter_ST.Weapons
{
    class Railgun : Weapon
    {
        public Railgun(PointF location) : base("Images/Rapidgun.png", location)
        {
            this.bulletSpeed = 25f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 100;
        }

        public override Bullet CreateBullet(Soldier s)
        {
            return new Bullet("Images/Bullet3.png", new PointF(), s);
        }
    }
}
