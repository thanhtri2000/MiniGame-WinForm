using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class Item
    {
        protected PictureBox item;
        protected Timer time = new Timer();
        protected int timeToDes = 0;
        private PictureBox map;
        private Random rd = new Random();
        //Constructor
        public Item() { }
        public Item(PictureBox map)
        {
            item = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            item.Top = item.Left = 0;
            this.map = map;
        }
        //Tạo item
        public virtual void CreateItem(PictureBox Map)
        {
            int x = rd.Next(1, 650);
            int y = rd.Next(33, 550);
            item.Parent = map;
            item.BackColor = Color.Transparent;
            item.Location = new Point(x, y);
            Map.Controls.Add(item);
            item.BringToFront();
            time.Interval = 1000;
            time.Tick += tm_Tick;
            time.Start();
        }

        protected void tm_Tick(object sender, EventArgs e)
        {
            if (timeToDes <= 0)
            {
                Destroy();
            }
            else
                timeToDes--;
        }
        public void Destroy()
        {
            time.Stop();
            timeToDes = 0;
            item.Dispose();
            map.Controls.Remove(item);
        }
    }
}
