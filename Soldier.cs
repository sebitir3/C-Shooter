using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Csharpshooter_ST.Weapons;

namespace Csharpshooter_ST
{
    public class Soldier
    {
        public Weapon currentWeapon;
        public PointF offset;
        Picture pic;
        public PointF location;
        public float facingAngle = 0;
        public float turnDirc = 0f;
        public int radius;

        public int walkDirc = 0;
        public PointF velocity;
        public int moveSpeed = 10;

        public bool isFiring = false;
        public float bulletSpeed = 20f;
        public int fireDelay = 500;
        public int timeSinceLastShot = 0;
        public float bulletStartDistance = 30f;
        public int HP = 30;
        public bool dead = false;
        
        public bool hitFlicker = false;
        public int hitFlickerCount = 0;

        public Soldier(String image, PointF location)
        {
            pic = new Picture(image, location, 4, 60);
            velocity = new PointF();
            this.location = location;
            radius = pic.bitmap.Width / 2;

            Random r = new Random((int)DateTime.Now.Ticks);
            facingAngle = r.Next(360);

            
        }

        public void Draw(Graphics g)
        {
            if (this.dead)
            {
               
                return;
            }
            
            pic.angle = facingAngle;
            
            if (!hitFlicker)
            {
                pic.location.X = location.X - MainForm.viewOffset.X;
                pic.location.Y = location.Y - MainForm.viewOffset.Y;

                pic.Draw(g);
                currentWeapon.Draw(g);
            }



        }

        public virtual void Update(int time)
        {
            facingAngle += ((float)(time)) * turnDirc;
            velocity.X = (float)Math.Cos(facingAngle / 180f * Math.PI) * walkDirc * moveSpeed;
            velocity.Y = -(float)Math.Sin(facingAngle / 180f * Math.PI) * walkDirc * moveSpeed;

            Move();
            UpdateWeapon(time);
            if (velocity.X !=0 || velocity.Y != 0)
                pic.Update(time);
            
            if (isFiring)
                currentWeapon.Fire(this);

            //we are dead
            if(HP <= 0)
            {
                dead = true;
                Weapons.Explosion e = new Weapons.Explosion(this.location);
                return;
            }

            

            //when soldier gets hit by a bullet it flickers
            if (hitFlickerCount > 0)
            {
                hitFlickerCount--;
                hitFlicker = !hitFlicker;
            }
            else
                hitFlicker = false;

            foreach(Wall w in MainForm.wallList)
            {
                PointF touchPoint = new PointF();
                if (this.isTouchingWall(w, ref touchPoint))
                    pushFrom(touchPoint);
            }

        }

        public void Move()
        {
            location.X += velocity.X;
            location.Y += velocity.Y;
        }

       

        public void TakeDamage(int damage)
        {
            HP -= damage;
            hitFlickerCount = 4;
        }

        public bool isTouchingWall(Wall w, ref PointF touchPoint)
        {
            //first we need the nearest point on the wall
            PointF nearestPoint = w.PointToNearestTo(this.location);

            //Now see if the nearest point is touching the wall using pythagorean theorm        
            float distance = (float)Math.Sqrt((nearestPoint.X - location.X) * (nearestPoint.X - location.X)
                + ((nearestPoint.Y - location.Y)) * (nearestPoint.Y - location.Y));

            //if the distance is < radius, that point is in circle
            //so we'll set touch point to nearest point and return tru to indicate that we found an overlap
            if (distance < this.radius)
            {
                touchPoint = nearestPoint;
                return true;
            }

            //otherwise we return false
            else return false;
        }

        public void pushFrom(PointF p)
        {
            //calc. the actual distance between p and soldier location using pyth. theorm.
            float actualDistance = (float)Math.Sqrt((p.X - location.X) * (p.X - location.X)
                + ((p.Y - location.Y)) * (p.Y - location.Y));

            //just leave this function if the actual distance is 0
            if (actualDistance == 0)
                return;

            //a float called disired distance is set to the radius of the soldier plus 1 to push him slightly off the wall
            float desiredDistance = this.radius + 1;

            //a float called proportion is a scaler, its the amount to ultiply against the move direction
            float proportion = desiredDistance / actualDistance;

            //initialize a new PointF vector called move and set x and y to the distance between
            //this soldier's and p's x and y, then adjust its length by multiplying it by the scaler above
            PointF move = new PointF(this.location.X - p.X, this.location.Y - p.Y);
            move.X *= proportion;
            move.Y *= proportion;

            //move this object away from p
            this.location.X = p.X + move.X;
            this.location.Y = p.Y + move.Y;
        }

        public void UpdateWeapon(int time)
        {
            //create to floats called x offsett and yoffset used to put gun in soldiers hands,
            // use sin and cos to fill offsets and a scaler of 32f
            float xOffset = (float)Math.Cos(facingAngle / 180f * Math.PI) * 32f;
            float yOffset = -(float)Math.Sin(facingAngle / 180f * Math.PI) * 32f;




            //set currentweapons' x and y location to slodiers hands
            currentWeapon.location.X = location.X + xOffset;
            currentWeapon.location.Y = location.Y + yOffset;

            //set the curent weaponds facing and to this soldeirs facing angle
            currentWeapon.facingAngle = this.facingAngle;

            //update the curretnweapon
            currentWeapon.Update(time);




        }

    }
}
