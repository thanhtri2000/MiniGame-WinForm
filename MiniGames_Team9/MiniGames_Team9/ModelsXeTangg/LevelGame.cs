using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class LevelGame
    {
        //Properties
        private int speed = 0;            //Tốc độ hiện title level
        public int level = 0;             //Level của game
        private Label label;              //Label hiện thị level
        private Timer timer = new Timer();//Quản lý thời gian hiện thị
        //Iniatialize
        public LevelGame() { }
        public LevelGame(Label label)
        {
            this.label = label;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
        }
        //Method
        //Tạo ra animation
        public void Animation()
        {
            label.Visible = true;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (level != 8)
            {
                if (speed % 2 == 0)
                    label.Text = "Level " + level.ToString();
                else
                    label.Text = "";
            }
            else
            {
                if (speed % 2 == 0)
                    label.Text = "YOU WIN !!!";
                else
                    label.Text = "";
            }
            if (speed > 150)
            {
                speed = 0;
                timer.Stop();
                label.Visible = false;
            }
            speed++;
        }
    }
}
