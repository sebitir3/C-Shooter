using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Csharpshooter_ST.Weapons
{
    public class Explosion
    {
        public PointF location;
        public Picture pic;
        public int life = 240;

        

        public Explosion(PointF location)
        {
            pic = new Picture("Images/Explode.png", location, 6, 40);
            this.location = location; 

            MainForm.explosionList.Add(this);
        }

        public virtual void Draw (Graphics g)
        {
            pic.location.X = location.X - MainForm.viewOffset.X;
            pic.location.Y = location.Y - MainForm.viewOffset.Y;

            pic.Draw(g);
        }

        public void Update(int time)
        {
            life -= time;

            if (life <= 0)
            {
                MainForm.explosionList.Remove(this);
                return;
            }

            pic.Update(time);
        }
    }
}
