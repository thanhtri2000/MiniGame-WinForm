using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    abstract class Figure
    {
        //Properties
        public PictureBox Avatar = new PictureBox();
        public PictureBox Map = new PictureBox();
        public Random rd = new Random();
        public Skin skin = new Skin();
        public bool locked;
        //Method
        //Method abstract tạo hình ảnh của firgue 
        public abstract void MakeAvatar();
        //Giảm độ cứng của xe tăng
        public abstract void DownState();
    }
}
