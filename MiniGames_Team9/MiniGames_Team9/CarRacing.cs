using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    public partial class CarRacing : Form
    {
        int gamespeed = 8;
        int score = 0;
        int x, y;
        public CarRacing()
        {
            InitializeComponent();
            //khai báo game over
            over.Visible = false;
        }

        private void gameTimer(object sender, EventArgs e)
        {
            // cho line tuột về sau
            moveline(gamespeed);
            // cho chiếc xe địch tuột về sau
            enemy(gamespeed);
            gameover();
            diamond(gamespeed);
            diamondcollection();
        }
        // random xe và KC
        Random a = new Random();

        // cho xe địch chay 
        void enemy(int speed)
        {
            //xe 1
            if (enemy1.Top >= 350)

            {
                // random vị trí xe ở lượt kế
                enemy1.Left = a.Next(0, 200);

                enemy1.Top = 0;
            }
            else
            { enemy1.Top += speed; }
            // xe 2
            if (enemy2.Top >= 350)
            {
                enemy2.Left = a.Next(0, 200);
                enemy2.Top = 0;
            }
            else
            { enemy2.Top += speed; }
            //xe 3
            if (enemy3.Top >= 350)
            {
                enemy3.Left = a.Next(0, 200);
                enemy3.Top = 0;
            }
            else
            { enemy3.Top += speed; }

        }

        // cho kim cương chạy
        void diamond(int speed)
        {
            if (dia1.Top >= 350)
            {
                // random vị trí dia ở lượt kế
                dia1.Left = a.Next(0, 200);

                dia1.Top = 0;
            }
            else
            { dia1.Top += speed; }
            // KC 2
            if (dia2.Top >= 350)
            {
                dia2.Left = a.Next(0, 200);
                dia2.Top = 0;
            }
            else
            { dia2.Top += speed; }
            //KC 3
            if (dia3.Top >= 350)
            {
                dia3.Left = a.Next(0, 200);
                dia3.Top = 0;
            }
            else
            { dia3.Top += speed; }
            //KC 4
            if (dia4.Top >= 350)
            {
                dia4.Left = a.Next(0, 200);
                dia4.Top = 0;
            }
            else
            { dia4.Top += speed; }
        }
        // tính điểm thu thap diamond
        void diamondcollection()
        {
            if (car.Bounds.IntersectsWith(dia1.Bounds))
            {
                score++;
                label1.Text = $" Score: {score}";
                // xe chạy lại nuốt lun KC
                dia1.Location = new Point(x, 0);
            }
            //KC2
            if (car.Bounds.IntersectsWith(dia2.Bounds))
            {
                score++;
                label1.Text = $" Score: {score}";

                dia2.Location = new Point(x, 0);
            }
            //KC3
            if (car.Bounds.IntersectsWith(dia3.Bounds))
            {
                score++;
                label1.Text = $" Score: {score}";
                dia3.Location = new Point(x, 0);
            }
            //KC4
            if (car.Bounds.IntersectsWith(dia4.Bounds))
            {
                score++;
                label1.Text = $" Score: {score}";
                dia4.Location = new Point(x, 0);
            }

        }
        // cho xe chạy bằng nút trái phải
        private void carkeyisdowm(object sender, KeyEventArgs e)
        {
            //cho xe qua trái phải lên lề đồ lun 
            // qua lề trái là 0, lề phải 250 (mò kích thước)
            if (e.KeyCode == Keys.Left && car.Left > 3) car.Left -= 20;
            if (e.KeyCode == Keys.Right && car.Left < 250) car.Left += 20;
            // tăng giảm tốc độ chạy
            // cao nhất là 50, thấp nhất là 5
            if (e.KeyCode == Keys.Up && gamespeed < 50) gamespeed++;
            if (e.KeyCode == Keys.Down && gamespeed > 5) gamespeed--;
        }


        // cho mấy cái line trắng chạy
        // > 350 thì nó sẽ nối tiếp nhau
        void moveline(int speed)
        {

            if (pictureBox1.Top > 350)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            // line 2
            if (pictureBox2.Top > 350)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            //line 3
            if (pictureBox3.Top > 350)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            //line4
            if (pictureBox4.Top > 350)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }
            // game over
            void gameover()
            {
                // nếu xe đụng địch thì tg ngừng và chữ gameover hiện lên
                if (car.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    timer1.Enabled = false;
                    over.Visible = true;


                }
                //
                if (car.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                }
                //
                if (car.Bounds.IntersectsWith(enemy3.Bounds))
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                }
            }


        }
  }

