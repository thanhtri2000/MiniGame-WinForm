using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class LoadingGame
    {
        //Properties
        private Xetang frmGame;            //Nơi màn hình chờ hiển thị
        private Timer timerback = new Timer();
        private Timer timerball = new Timer();
        private Timer timerrocket = new Timer();
        private PictureBox screen;
        private PictureBox ball;
        private PictureBox rocket;
        private Panel linerocket;
        private Panel cover;
        private Label loading;
        private Label introduction;
        private int wd = 0, down = 1, lt = 5, rocktop = -1;
        //Initialize
        public LoadingGame() { }
        public LoadingGame(Xetang frmGame)
        {
            this.frmGame = frmGame;
        }
        //Method
        //Hàm khởi tạo màn hình chờ loading game
        private void InitControls()
        {
            screen = new PictureBox
            {
                BackColor = Color.Black,
                Size = new Size(785, 610)
            };
            ball = new PictureBox
            {
                Size = new Size(6, 6),
                Location = new Point(104, 315),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            rocket = new PictureBox
            {
                Size = new Size(64, 64),
                Location = new Point(104, 330),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            linerocket = new Panel
            {
                Size = new Size(104, 4),
                Location = new Point(341, 320),
                BackColor = Color.Blue
            };
            cover = new Panel
            {
                Size = new Size(104, 89),
                Location = new Point(341, 321),
                BackColor = Color.Transparent
            };
            loading = new Label
            {
                Font = new Font("Times New Roman", 10.0f),
                Location = new Point(10, 10),
                ForeColor = Color.Yellow,
                Text = "Game loading..."
            };
            introduction = new Label
            {
                Font = new Font("Times New Roman", 12.0f, FontStyle.Italic),
                Location = new Point(141, 421),
                ForeColor = Color.White,
                Text = "Thế chiến 3, thứ 6 ngày 13/1/2050. Quân địch đã xâm chiếm thành phố chúng ta...",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            cover.Parent = screen;
            frmGame.Controls.Add(screen);
            screen.BringToFront();
            screen.Controls.Add(ball);
            screen.Controls.Add(rocket);
            screen.Controls.Add(linerocket);
            screen.Controls.Add(cover);
            screen.Controls.Add(loading);
            cover.BringToFront();
            loading.BringToFront();
            loading.Parent = cover;
            cover.Controls.Add(loading);

        }
        //Hàm đăng kí sự kiện cho các timer và bắt đầu chạy màn hình loading game
        public void InitEvents()
        {
            InitControls();
            timerback.Tick += new EventHandler(animationLine);
            timerball.Tick += new EventHandler(animationBall);
            timerrocket.Tick += new EventHandler(animationRocket);
            MakeScreen();
        }
        //Hàm khởi tạo màn hình loading game
        private void MakeScreen()
        {
            linerocket.Height = 1;
            linerocket.Width = 0;
            linerocket.Left = 141;
            ball.Top = 262;
            ball.Visible = false;
            ball.BringToFront();
            rocket.Height = 64;
            rocket.Top = 320;
            rocket.Visible = false;
            //Image location
            ball.Image = Properties.Resources.circleblue;
            rocket.Image = Properties.Resources.ic_tank;
            //Timer interval
            timerback.Interval = 30;
            timerball.Interval = 40;
            timerrocket.Interval = 10;
            timerback.Start();
        }
        private void animationLine(object sender, EventArgs e)
        {

            linerocket.Width += wd;
            screen.Controls.Add(introduction);
            if (linerocket.Width < 1)
            {
                wd = 5;
            }
            if (linerocket.Width > 504)
            {
                timerback.Stop();
                timerrocket.Start();
            }
        }
        private void animationBall(object sender, EventArgs e)
        {
            ball.Top += down;
            if (ball.Top < 265)
            {
                ball.Visible = true;
                down = 1;
            }
            if (ball.Top > 305)
            {
                timerball.Interval = 10;
                rocket.Image = Properties.Resources.ic_tank;
                ball.Visible = false;
                down = 5;
                rocket.Left += 5;
                if (rocket.Left > 504)
                {
                    linerocket.Width -= lt;
                    linerocket.Left += lt;
                    introduction.Location = new Point(321, 421);
                    introduction.Text = "Chúc bạn may mắn...";
                    if (linerocket.Left > 670)
                    {
                        down = 1;
                        timerball.Stop();
                        DestroyScreen();
                    }
                }
            }

        }
        private void animationRocket(object sender, EventArgs e)
        {
            rocket.Top += rocktop;
            if (rocket.Top > 318)
            {
                rocket.Visible = true;
                rocktop = -5;
            }
            if (rocket.Top < 250)
            {
                rocktop = -1;
                introduction.Location = new Point(200, 421);
                introduction.Text = "Bạn là người mang sứ mệnh bảo vệ thành phố, hãy cố gắng bạn nhé...";
                timerrocket.Stop();
                timerball.Start();
            }
        }
        //Hàm hủy màn hình chờ loading game
        private void DestroyScreen()
        {
            frmGame.Controls.Remove(screen);
            frmGame.isStart = true;
            frmGame.GameStart();
        }
    }
}
