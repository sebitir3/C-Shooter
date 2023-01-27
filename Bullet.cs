using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Csharpshooter_ST
{
    public class Bullet
    {
        Picture pic;
        public PointF location;
        public PointF velocity;
        public int radius;
        public int damage = 4;

        public float life = 1.0f;
        //in seconds

        Soldier parent;

        public Bullet(string Image, PointF location, Soldier s)
        {
            parent = s;
            pic = new Picture(Image, location, 4, 25);
            this.location = location;
            velocity = new PointF();
            radius = pic.bitmap.Width / 2;
            MainForm.bulletList.Add(this);
        }

        public virtual void Draw(Graphics g)
        {

            pic.location.X = location.X - MainForm.viewOffset.X;
            pic.location.Y = location.Y - MainForm.viewOffset.Y;
            pic.Draw(g);

        }

        public void Update(int time)
        {
            
            Move();
            pic.Update(time);

            life -= (float)time / 1000f;

            if(life <= 0)
            {
                MainForm.bulletList.Remove(this);
            }
        if (parent == MainForm.player1)
            {
                for (int i = 0; i < MainForm.enemyList.Count; i++)
                    if (this.isTouching(MainForm.enemyList[i]))
                    {
                        MainForm.enemyList[i].TakeDamage(damage);
                        MainForm.bulletList.Remove(this);
                    }
            }

            //all bullets can hit the player, unless the player is dead

            if (this.isTouching(MainForm.player1) && !MainForm.player1.dead)
            {
                MainForm.player1.TakeDamage(damage);
                MainForm.bulletList.Remove(this);
            }

            foreach (Wall w in MainForm.wallList)
            {
                if (this.isTouchingWall(w))
                {
                    this.backUpPosition();

                    PointF normal = w.normalAtNP(this.location);
                    this.bounceFrom(normal);
                }
            }



        }

        



        public virtual void Move()
        {
            location.X += velocity.X;
            location.Y += velocity.Y;
        }

        public bool isTouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) * (s.location.X - this.location.X) + (s.location.Y - this.location.Y) * (s.location.Y - this.location.Y));

            return distance < this.radius + s.radius;
        }

        public bool isTouchingWall(Wall w)
        {
            //first we need the nearest point on the wall
            PointF nearestPoint = w.PointToNearestTo(this.location);

            //Now see if the nearest point is touching the wall using pythagorean theorm        
            float distance = (float)Math.Sqrt((nearestPoint.X - location.X) * (nearestPoint.X - location.X)
                + ((nearestPoint.Y - location.Y)) * (nearestPoint.Y - location.Y));

            //if the distance is < radius, that point is in circle
            //so we'll set touch point to nearest point and return tru to indicate that we found an overlap
            if (distance < this.radius)
                return true;
            

            //otherwise we return false
            else return false;
        }

        public void backUpPosition()
        {
            this.location.X -= this.velocity.X;
            this.location.Y -= this.velocity.Y;
        }

        public void bounceFrom(PointF normal)
        {
            //create a new pointf vector called R and set it equal to this bullets velocity vector

            PointF R;

            //applying the dot product to create b in the equation R = I - 2b

            float b = (velocity.X * normal.X + velocity.Y * normal.Y);

            //create the 2b in the equation

            b *= 2;

            //create the new reflection vector, R = new velocity vector and I = old velocity vector,
            //we multiply bouncefact by the normal in order to turn bounce factor into a vector

            R = new PointF(this.velocity.X - normal.X * b, this.velocity.Y - normal.Y * b);

            //finally set this bullets new reflected vector = to R

            this.velocity.X = R.X;
            this.velocity.Y = R.Y;

        }













    }





}
