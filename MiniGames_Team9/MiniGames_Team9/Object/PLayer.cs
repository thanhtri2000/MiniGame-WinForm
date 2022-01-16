using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace MiniGames_Team9
{
    class PLayer : Figure
    {
        #region properties
        public int bulletLevel = 1;      //Level của đạn 
        public int delay = 2;            //Thời gian thay đạn
        public int timedelay = 2;
        public bool isCanShoot = true;
        public int speed = 5;          //Tốc độ player
        public double playerHealth = 100;//Máu của player
        public FigureState state = FigureState.weak;//Độ cứng của player
        private bool goup;
        private bool goleft;
        private bool goright;
        private bool godown;
        private Direction facing = Direction.up;  //Cho biết hướng hiện tại của player 
        public int dame = 110;
        #endregion
        #region Contructor
        public PLayer() { }
        public PLayer(PictureBox Map)
        {
            this.Map = Map;
        }
        #endregion
        #region Method
        public override void MakeAvatar()
        {
            Avatar.Image = skin.imup;
            Avatar.SizeMode = PictureBoxSizeMode.AutoSize;
            Avatar.Location = new Point(288, 548);
            Avatar.Tag = "Avatar";
            Map.Controls.Add(Avatar);
            Avatar.BringToFront();
        }
        public void PressKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                facing = Direction.left;
                Avatar.Image = skin.imleft;
                goright = false;
                goup = false;
                godown = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = Direction.right;
                Avatar.Image = skin.imright;
                goup = false;
                godown = false;
                goleft = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goup = true;
                facing = Direction.up;
                Avatar.Image = skin.imup;
                goright = false;
                godown = false;
                goleft = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                godown = true;
                facing = Direction.down;
                Avatar.Image = skin.imdown;
                goright = false;
                goup = false;
                goleft = false;
            }
        }
        //Bắt sự kiện người chơi nhả phím
        public void DropKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (isCanShoot)
                {
                    Shoot(facing);
                    isCanShoot = false;
                }
                else
                {
                    delay--;
                    if (delay == 0)
                    {
                        delay = timedelay;
                        isCanShoot = true;
                    }
                }
            }
        }

        //Di chuyển nhân vật
        public void MoveAvatar(object sender, EventArgs e)
        {
            if (goleft && Avatar.Left > 0)
            {
                foreach (Control c in Map.Controls)
                    if (c is PictureBox && Equals(c.Tag, "attacker") || Equals(c.Tag, "Thep") || Equals(c.Tag, "defense") || Equals(c.Tag, "Gach") || Equals(c.Tag, "Spawn"))
                    {
                        PictureBox p = NextLocationPlayer(Direction.left, speed);
                        if (c.Bounds.IntersectsWith(p.Bounds))
                        {
                            return;
                        }
                    }
                Avatar.Left -= speed;
            }
            if (goright && Avatar.Left + Avatar.Width < 800)
            {
                foreach (Control c in Map.Controls)
                    if (c is PictureBox && Equals(c.Tag, "attacker") || Equals(c.Tag, "Thep") || Equals(c.Tag, "defense") || Equals(c.Tag, "Gach") || Equals(c.Tag, "Spawn"))
                    {
                        PictureBox p = NextLocationPlayer(Direction.right, speed);
                        if (c.Bounds.IntersectsWith(p.Bounds))
                        {
                            return;
                        }
                    }
                Avatar.Left += speed;
            }
            if (goup && Avatar.Top > 30)
            {
                foreach (Control c in Map.Controls)
                    if (c is PictureBox && Equals(c.Tag, "attacker") || Equals(c.Tag, "Thep") || Equals(c.Tag, "defense") || Equals(c.Tag, "Gach") || Equals(c.Tag, "Spawn"))
                    {
                        PictureBox p = NextLocationPlayer(Direction.up, speed);
                        if (c.Bounds.IntersectsWith(p.Bounds))
                        {
                            return;
                        }
                    }
                Avatar.Top -= speed;
            }
            if (godown && Avatar.Top + Avatar.Height < 620)
            {
                foreach (Control c in Map.Controls)
                    if (c is PictureBox && Equals(c.Tag, "attacker") || Equals(c.Tag, "Thep") || Equals(c.Tag, "defense") || Equals(c.Tag, "Gach") || Equals(c.Tag, "Spawn"))
                    {
                        PictureBox p = NextLocationPlayer(Direction.down, speed);
                        if (c.Bounds.IntersectsWith(p.Bounds))
                        {
                            return;
                        }
                    }
                Avatar.Top += speed;
            }
        }
        //Hàm bắn súng của người chơi
        private void Shoot(Direction direct)
        {
            Bullet gun = null;
            gun = new BulletSimple(direct, Avatar, "Red");
            Sound.PlayerShoot();
            gun.BulletControl(Map);
            gun.speed = speed + 1;
        }
        #endregion
        //Tính khoảng cách giữ 2 Picture
        private int Distance(PictureBox a, PictureBox b, Direction direct)
        {
            int dis = 0;
            if (direct == Direction.down)
            {
                dis = a.Top + a.Height - b.Top;
            }
            else if (direct == Direction.up)
            {
                dis = b.Top + b.Height - a.Top;
            }
            else if (direct == Direction.left)
            {
                dis = a.Left - (b.Left + b.Width);
            }
            else if (direct == Direction.right)
            {
                dis = b.Left - (a.Left + a.Width);
            }
            return dis;
        }
        private PictureBox NextLocationPlayer(Direction direct, int speed)
        {
            PictureBox p = new PictureBox();
            p.Size = Avatar.Size;
            p.Location = Avatar.Location;
            if (direct == Direction.down)
            {
                p.Location = new Point(Avatar.Location.X, Avatar.Location.Y + speed);
            }
            else if (direct == Direction.up)
            {
                p.Location = new Point(Avatar.Location.X, Avatar.Location.Y - speed);
            }
            else if (direct == Direction.left)
            {
                p.Location = new Point(Avatar.Location.X - speed, Avatar.Location.Y);
            }
            else if (direct == Direction.right)
            {
                p.Location = new Point(Avatar.Location.X + speed, Avatar.Location.Y);
            }
            return p;
        }
        public override void DownState()
        {
            if (state == FigureState.strong)
            {
                state = FigureState.medium;
                skin.MakePlayer2();
                timedelay = 2;
                bulletLevel = 1;
                dame = 120;
                playerHealth = 100;
            }
            else if (state == FigureState.medium)
            {
                state = FigureState.weak;
                skin.MakePlayer1();
                bulletLevel = 1;
                dame = 110;
                playerHealth = 100;
            }
        }
        public void UpState()
        {
            if (state == FigureState.weak)
            {
                state = FigureState.medium;
                skin.MakePlayer2();
                bulletLevel = 1;
                Sound.TakeItem();
            }
            else if (state == FigureState.medium)
            {
                state = FigureState.strong;
                skin.MakeSuperPlayer();
                bulletLevel = 1;
                Sound.TakeItem();
                timedelay = 1;
            }
        }
    }
}
