using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9 
{ 
    abstract class Attacker : Enemy
    {
        //Properties
        public static bool isStand;
        protected Point vt;
        public double attackerHealth = 100;
        public FigureState state;
        protected int maxHealth = 100;
        protected int timeDelay;
        private int timeStand = 0;
        //Constructor
        public Attacker(PictureBox MAP)
        {
            Map = MAP;
        }
        public Attacker(PictureBox MAP, Point vt, Direction direc)
            : base(MAP)
        {
            this.vt = vt;
            direction = direc;
        }
        //Method
        //Hàm tạo ra attacker
        public override void MakeAvatar()
        {
            MakeDirection();
            Avatar.Height = 40;
            Avatar.Width = 40;
            Avatar.Tag = "attacker";
            Avatar.Location = new Point(vt.X, vt.Y);
            Map.Controls.Add(Avatar);
        }
        //Hàm tạo hướng của attacker
        private void MakeDirection()
        {
            if (direction == Direction.left)
                Avatar.Image = skin.imleft;
            else if (direction == Direction.right)
                Avatar.Image = skin.imright;
            else if (direction == Direction.up)
                Avatar.Image = skin.imup;
            else if (direction == Direction.down)
                Avatar.Image = skin.imdown;
        }
        //Hàm bắn súng
        public void Shoot()
        {
            Bullet gun = new BulletSimple(direction, Avatar, "Orange");
            gun.speed = speed + 3;
            gun.BulletControl(Map);
        }
        //Hàm trả về vị trí tọa độ của viên đạn
        private Point SetLocationBullet(Direction direct)
        {
            Point temp = new Point();
            if (direct == Direction.up)
            {
                temp.X = Avatar.Left + Avatar.Width / 2;
                temp.Y = Avatar.Top;
            }
            else if (direct == Direction.down)
            {
                temp.X = Avatar.Left + Avatar.Width / 2;
                temp.Y = Avatar.Top + Avatar.Height;
            }
            else if (direct == Direction.left)
            {
                temp.X = Avatar.Left;
                temp.Y = Avatar.Top + Avatar.Height / 2;
            }
            else if (direct == Direction.right)
            {
                temp.X = Avatar.Left + Avatar.Width;
                temp.Y = Avatar.Top + Avatar.Height / 2;
            }
            return temp;
        }
        //Hàm di chuyển attacker
        public override void MoveEnemy()
        {
            if (!isStand)
            {
                switch (direction)
                {
                    case Direction.up:
                        Avatar.Top -= speed;
                        Avatar.Image = skin.imup;
                        break;
                    case Direction.down:
                        Avatar.Top += speed;
                        Avatar.Image = skin.imdown;
                        break;
                    case Direction.right:
                        Avatar.Left += speed;
                        Avatar.Image = skin.imright;
                        break;
                    case Direction.left:
                        Avatar.Left -= speed;
                        Avatar.Image = skin.imleft;
                        break;
                }
                AttackerShoot();
                timeStand = 0;
            }
            else
            {
                if (timeStand == 0)
                {
                    Shoot();
                    timeStand = 50;
                }
                else
                    timeStand--;
            }

        }
        //Hàm thay đổi độ cứng của Attacker
        public override void DownState()
        {
            if (state == FigureState.strong)
            {
                state = FigureState.medium;
                speed--;
            }
            else if (state == FigureState.medium)
            {
                state = FigureState.weak;
                speed--;
            }
            MakeAttacker();
        }
        public abstract void MakeAttacker();
        public abstract void AttackerShoot();
    }
}


