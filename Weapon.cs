using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpshooter_ST
{
    public abstract class Weapon
    {
        public Picture pic;
        public PointF location;

        public float bulletSpeed;
        public int fireDelay;
        public float bulletStartDistance;
        public float facingAngle;
        public int timeSinceLastShot = 0;

        public Weapon(String image, PointF location)
        {
            this.pic = new Picture(image, location, 1, 1);
            this.location = location;
        }

        public void Draw(Graphics g)
        {
            pic.angle = facingAngle;
            pic.location.X = location.X - MainForm.viewOffset.X;
            pic.location.Y = location.Y - MainForm.viewOffset.Y;
            pic.Draw(g);
        }

        public void Update(int time)
        {
            timeSinceLastShot += time;
        }

        public void Fire(Soldier s)
        {
            if (timeSinceLastShot < fireDelay)
                return;

            timeSinceLastShot = 0;

            float xComponent = (float)Math.Cos(facingAngle / 180f * Math.PI);
            float yComponent = -(float)Math.Sin(facingAngle / 180f * Math.PI);


            Bullet bullet = CreateBullet(s);

            bullet.location.X = this.location.X + xComponent * bulletStartDistance;
            bullet.location.Y = this.location.Y + yComponent * bulletStartDistance;

            bullet.velocity.X = xComponent * bulletSpeed;
            bullet.velocity.Y = yComponent * bulletSpeed;

        }

        public abstract Bullet CreateBullet(Soldier s);
    }
}
