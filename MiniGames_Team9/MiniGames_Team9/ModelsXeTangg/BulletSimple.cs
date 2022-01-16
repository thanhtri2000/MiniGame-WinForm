using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class BulletSimple : Bullet
    {
        //Properties
        private PictureBox bullet = new PictureBox();
        //Constructor
        public BulletSimple() { }
        public BulletSimple(Direction direct, PictureBox avartar, string color)
            : base(direct, avartar, color)
        {
        }
        //Method
        public override void BulletControl(PictureBox Map)
        {
            CreateBullet(bullet, Map);
            base.BulletControl(Map);
        }
        //Hàm di chuyển viên đạn
        protected override void MoveBullet()
        {
            if (direction == Direction.left)
            {
                bullet.Left -= speed;
            }
            if (direction == Direction.right)
            {
                bullet.Left += speed;
            }
            if (direction == Direction.up)
            {
                bullet.Top -= speed;
            }
            if (direction == Direction.down)
            {
                bullet.Top += speed;
            }
            //Hủy đạn nếu đạn ra ngoài màn hình
            if (bullet.Left < 0 || bullet.Left > 800 || bullet.Top < 30 || bullet.Top > 650)
            {
                tm.Stop();
                tm.Dispose();
                bullet.Dispose();
                tm = null;
                bullet = null;
            }
        }
    }
}
