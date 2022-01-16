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
    public partial class FormMenu : Form
    {
        //Properties
        private List<PictureBox> buttonList = new List<PictureBox>();
        private LoadData data = new LoadData();
        private Xetang frmGameplay;
        private LoadingGame gameLoading;
        public int select = 0;             //Cho biết lựa chọn của người chơi khi chọn nhân vật
        //Constructor
        public FormMenu()
        {
            InitializeComponent();
           
            DrawLogin();
           
            frmGameplay = new Xetang(this);
            gameLoading = new LoadingGame(frmGameplay);
            frmGameplay.Hide();
        }

        private void DrawLogin()
        {
            InitButtons();
            for (int i = 0; i < 4; i++)
                this.Controls.Add(buttonList[i]);
        }

        private void InitButtons()
        {
            PictureBox picTemp = new PictureBox { Height = 0, Location = new Point(111, 30) };
            for (int i = 0; i < 6; i++)
            {
                PictureBox ptb = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    BackColor = Color.Transparent,
                    Location = new Point(picTemp.Location.X, picTemp.Location.Y + picTemp.Height + 25),
                    Tag = i.ToString()
                };
                picTemp = ptb;
                ptb.Click += ptb_Click;
                ptb.MouseHover += ptb_MouseHover;
                ptb.MouseLeave += ptb_MouseLeave;
                buttonList.Add(ptb);
            }
            GetImage();
        }

        private void GetImage()
        {

            buttonList[0].Image = Properties.Resources.btnPlay;
         
       
            buttonList[3].Image = Properties.Resources.btnQuit;
            buttonList[4].Image = Properties.Resources.btnReplay;
            buttonList[5].Image = Properties.Resources.btnHome;
        }

        private void ptb_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Transparent;
        }

        private void ptb_MouseHover(object sender, EventArgs e)
        {

            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.LightGreen;
        }

        private void ptb_Click(object sender, EventArgs e)
        {
            Sound.ClickSound();
            PictureBox btn = sender as PictureBox;
            if (Equals(btn.Tag, "0"))
            {
                this.Hide();
                frmGameplay.Show();
                gameLoading.InitEvents();
            }
            else if (Equals(btn.Tag, "1"))
                ShowFormHighscore();
            else if (Equals(btn.Tag, "2"))
                ShowFormAbout();
            else if (Equals(btn.Tag, "3"))
            {
                if (MessageBox.Show("Bạn muốn thoát chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Application.Exit();

            }
            else if (Equals(btn.Tag, "4"))
            {
                this.Hide();
                frmGameplay.Show();
                frmGameplay.GameStart();
            }
            else if (Equals(btn.Tag, "5"))
            {
                ShowFormLogin();
            }
        }

        private void ShowFormLogin()
        {
            this.BackgroundImage = Properties.Resources.bgr;
            foreach (Control x in this.Controls)
                if (x is PictureBox)
                {
                    if (Equals(x.Tag, "highscore"))
                    {
                        this.Controls.Remove(x);
                    }
                }
            for (int i = 0; i < 5; i++)
                buttonList[i].Visible = true;
            this.Controls.Remove(buttonList[4]);
            this.Controls.Remove(buttonList[5]);
            frmGameplay.Hide();
            this.Show();
        }

        private void ShowFormAbout()
        {
            PictureBox btnAbout = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Tag = "about"
            };
            btnAbout.Image = Properties.Resources.about;
            this.Controls.Add(btnAbout);
            btnAbout.BringToFront();
            PictureBox btnHome = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent,
                Location = new Point(btnAbout.Width - 65, 5),
                Tag = "home"
            };
            btnHome.Image = Properties.Resources.picHome;
            btnHome.Click += picHome_Click;
            btnHome.MouseHover += btnHome_MouseHover;
            btnHome.MouseLeave += btnHome_MouseLeave;
            btnAbout.Controls.Add(btnHome);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Red;
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Transparent;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Sound.ClickSound();
            this.BackgroundImage = Properties.Resources.bgr;
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (Equals(item.Tag, "about") || Equals(item.Tag, "home")))
                {
                    item.Dispose();
                    this.Controls.Remove(item);
                }
            }
        }

        internal void UpdateScore(int score, double clock)
        {
           
        }
        private void ShowFormHighscore()
        {
            PictureBox btnHighscore = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Tag = "highscore"
            };
            btnHighscore.Image = Properties.Resources.picHighScore;
            this.Controls.Add(btnHighscore);
            List<Label> scoreList = new List<Label>();
            for (int i = 0; i < 4; i++)
                buttonList[i].Visible = false;
            for (int i = 0; i < 4; i++)
            {
                Label lb = new Label
                {
                    BackColor = Color.Transparent,
                    Location = new Point(buttonList[i].Location.X - 20, buttonList[i].Location.Y),
                    Font = new Font("Segoe UI", 17.5f, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = Color.Yellow,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                scoreList.Add(lb);
            }
            scoreList[0].Text = "1st. " + data.scores[3] + ": " + Math.Round(data.times[3], 2) + "s";
            scoreList[1].Text = "2nd. " + data.scores[2] + ": " + Math.Round(data.times[2], 2) + "s";
            scoreList[2].Text = "3rd. " + data.scores[1] + ": " + Math.Round(data.times[1], 2) + "s";
            scoreList[3].Text = "4th. " + data.scores[0] + ": " + Math.Round(data.times[0], 2) + "s";
            buttonList[5].Location = new Point(buttonList[0].Location.X, buttonList[4].Location.Y);
            foreach (Label item in scoreList)
                btnHighscore.Controls.Add(item);
            buttonList[3].Visible = false;
            btnHighscore.Controls.Add(buttonList[5]);
        }
        //Hiển thị form kết thúc game
        public void ShowFormEnd()
        {
            //#NOTE
            //this.BackgroundImage = Color.Black;
            buttonList[4].Location = new Point(buttonList[0].Location.X, buttonList[0].Location.Y);
            buttonList[5].Location = new Point(buttonList[1].Location.X, buttonList[1].Location.Y);
            for (int i = 0; i < 3; i++)
                buttonList[i].Visible = false;
            this.Controls.Add(buttonList[4]);
            this.Controls.Add(buttonList[5]);
        }
    }
}
