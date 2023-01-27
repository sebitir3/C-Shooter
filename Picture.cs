using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Csharpshooter_ST
{
    public class Picture
    {
        public Bitmap bitmap;
        public PointF location;
        public float angle = 135f;
        public PointF offset;

        //animation stuff
        public int frame = 0; //current frame
        public int frameCount; //total number of frames
        public int frameTick; //ticks spent per frame
        public int animationCounter = 0;
        public Picture(string filename, PointF location, int frameCount, int frameTick)
        {
            this.frameCount = frameCount;
            this.frameTick = frameTick;
            bitmap = new Bitmap(filename);
            this.location = location;
            offset = new PointF(bitmap.Width / 2f, bitmap.Height / this.frameCount / 2f);
        }

        public void Draw(Graphics g)
        {
            Point drawLocation = new Point((int)(location.X - offset.X), (int)(location.Y - offset.Y));
            Matrix m = new Matrix();
            m.RotateAt(- angle, location);
            g.Transform = m;
            g.DrawImage(bitmap, new Rectangle(drawLocation.X, drawLocation.Y, bitmap.Width, bitmap.Height / this.frameCount), new Rectangle(0, this.frame * bitmap.Height / this.frameCount, bitmap.Width, bitmap.Height / this.frameCount), GraphicsUnit.Pixel);
           

        }

        public void Update(int time)
        {
            animationCounter += time;

            if (animationCounter >= this.frameTick)
            {
                this.frame ++;
                if (this.frame >= this.frameCount)
                {
                    frame = 0;
                }
                animationCounter = 0;
            }
        }
        














    }

    
}
