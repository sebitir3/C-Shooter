using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpshooter_ST
{
    public class Wall
    {
        public int width, height;
        public int left, top;
        

        Bitmap image;

        public Wall(String color, int left, int top, int width, int height)
        {
            image = new Bitmap("Images/" + color + "Box.png");
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;

            MainForm.wallList.Add(this);
        }

        public void Draw(Graphics g)
        {
            g.Transform = new Matrix();
            g.DrawImage(image, new Rectangle(left - MainForm.viewOffset.X, top - MainForm.viewOffset.Y, width, height));
        }

        
        //determine the pont on the wall that soldier is touching
        public PointF PointToNearestTo(PointF p)
        {
            //initialize new point f
            PointF nearestPoint = new PointF();

            //check if the left edge of the wall is to the right of point p
            //if true, then the nearest points x coordinate must be the left edge of the wall
            if (this.left > p.X)
                nearestPoint.X = this.left;

            //else if the right edge of wall is to the left of p
            //the nearest point's x coordinate must be the right edge of wall
            else if (this.left + this.width < p.X)
                nearestPoint.X = this.left + this.width;

            //if its not to the left or right it MUST be inside the wall
            //so we'll set nearest point's X cordinate equal to p's X coordinate
            else
                nearestPoint.X = p.X;

            if (this.top > p.Y)
                nearestPoint.Y = this.top;

            else if (this.top + this.height < p.Y)
                nearestPoint.Y = this.top + this.height;

            else
                nearestPoint.Y = p.Y;

            return nearestPoint;


        }

        public PointF normalAtNP(PointF p)
        {
            //create a pointf called nearestpoint and set it equal to the point on this wall nearest to p

            PointF nearestPoint = this.PointToNearestTo(p);

            //create a pointf vector called narmal and set its direction pointing from nearestpoint to p

            PointF normal = new PointF();
            normal.X = p.X - nearestPoint.X;
            normal.Y = p.Y - nearestPoint.Y;

            //using the normal, make sure its length is set to 1. if the length of the normal = 0
            //we can't resize it, so just return and exit

            if (normal.X == 0 && normal.Y == 0)
                return normal;
            

            //create a float called factor and set it = to the INVERSE of the normal's length 

            float factor = 1f / (float)Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y);

            //multiplying normal by that factor should result in a normal with a length of 1

            normal.X *= factor;
            normal.Y *= factor;

            //return the normal
            return normal;
        }






    }
}
