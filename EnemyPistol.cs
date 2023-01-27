using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpshooter_ST.Weapons
{
    public class EnemyPistol : Weapon
    {
        public EnemyPistol(PointF location) : base("Images/Pistol.png", location)
        {
            this.bulletSpeed = 15f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 600;
        }

        public override Bullet CreateBullet(Soldier s)
        {
            return new Bullet("Images/Bullet1.png", new PointF(), s);
        }
    }

}
