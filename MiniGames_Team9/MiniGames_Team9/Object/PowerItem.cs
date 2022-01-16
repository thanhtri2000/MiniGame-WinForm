using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class PowerItem : Item
    {
        //Constructor
        public PowerItem() { }
        public PowerItem(PictureBox map)
            : base(map)
        {
            item.Image = Properties.Resources.power_stone;
            timeToDes = 5;  //Thời gian item tồn tại
            item.Tag = "power";
        }
        //Method
        //Hàm tạo ra item power
        public override void CreateItem(PictureBox Map)
        {
            timeToDes = 2;
            Random rd = new Random();
            int x, y;
            do
            {
                x = rd.Next(1, 650);
                y = rd.Next(33, 550);
            } while (IsLocationPlayer(x, y, Map));
            item.Parent = Map;
            item.BackColor = Color.Transparent;
            item.Location = new Point(x, y);
            Map.Controls.Add(item);
            time.Interval = 1000;
            time.Tick += tm_Tick;
            time.Start();
        }
        //Kiểm tra xem vị trí item tạo ra có trùng với người chơi không
        //Nếu có trả về true, ngược lại false
        private bool IsLocationPlayer(int x, int y, PictureBox Map)
        {
            PictureBox person = null;
            foreach (Control sender in Map.Controls)
                if (sender is PictureBox && Equals(sender.Tag, "player"))
                {
                    person = (PictureBox)sender;
                    break;
                }
            if (person == null)
                return false;
            else
            {
                if (x == person.Left && y == person.Top)
                    return true;
                return false;
            }
        }
    }
}
