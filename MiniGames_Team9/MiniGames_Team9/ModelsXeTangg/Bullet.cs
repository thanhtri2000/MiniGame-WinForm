using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    abstract class Bullet
    {
        //Properties
        public int speed = 5;               //Tốc độ của đạn
        protected Direction direction;          //Hướng bắn của viên đạn
        protected Timer tm = new Timer();   //Thời gian đạn di chuyển
        protected PictureBox pictureCurrent;//Hình ảnh của viên đạn
        protected string color;
        //Constructor
        public Bullet()
        {
            direction = Direction.left;
        }
        public Bullet(Direction direct, PictureBox ptb, string color)
        {
            this.direction = direct;
            this.pictureCurrent = ptb;
            this.color = color;
        }
        //Method
        //Tạo đạn 
        protected void CreateBullet(PictureBox bullet, PictureBox Map)
        {
            Point td = SetLocationBullet(direction, pictureCurrent);
            if (color == "Red")
                bullet.BackColor = Color.Red;
            else
                bullet.BackColor = Color.Yellow;
            bullet.Size = new Size(8, 8);
            bullet.Tag = "bullet" + color;
            bullet.Left = td.X;
            bullet.Top = td.Y;
            Map.Controls.Add(bullet);
            bullet.BringToFront();
        }
        //Đạn di chuyển sau 1 frame của timer
        public virtual void BulletControl(PictureBox Map)
        {
            tm.Interval = speed;
            tm.Tick += tm_Tick;
            tm.Start();
        }
        private Point SetLocationBullet(Direction direct, PictureBox Avatar)
        {
            Point temp = new Point();
            if (direct == Direction.up)
            {
                temp.X = Avatar.Left + Avatar.Width / 2 - 4;
                temp.Y = Avatar.Top - 4;
            }
            else if (direct == Direction.down)
            {
                temp.X = Avatar.Left + Avatar.Width / 2 - 4;
                temp.Y = Avatar.Top + Avatar.Height - 4;
            }
            else if (direct == Direction.left)
            {
                temp.X = Avatar.Left - 4;
                temp.Y = Avatar.Top + Avatar.Height / 2 - 4;
            }
            else
            {
                temp.X = Avatar.Left + Avatar.Width - 4;
                temp.Y = Avatar.Top + Avatar.Height / 2 - 4;
            }
            return temp;
        }
        protected void tm_Tick(object sender, EventArgs e)
        {
            MoveBullet();

        }
        protected abstract void MoveBullet();
    }
}
