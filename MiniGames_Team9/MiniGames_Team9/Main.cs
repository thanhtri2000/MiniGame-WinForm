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
    public partial class frmMain : Form
    {
        public bool Thoat = true;
        public frmMain()
        {
            InitializeComponent();
            Sidepanel.Height = btnHome.Height;
            Sidepanel.Top = btnHome.Top;
            home1.BringToFront();


        }
        // di chuyen form main
        int movX = 0, movY = 0;
        bool movD;
        public event EventHandler Dangxuat;
        // di chuyen form main
     
       

        //User control Home
        private void button7_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnHome.Height;
            Sidepanel.Top = btnHome.Top;
            home1.BringToFront();
           
        }
        //User control Score
        private void button8_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnSroce.Height;
            Sidepanel.Top = btnSroce.Top;
            score1.BringToFront();

        }
        // thoát khỏi form main
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            movD = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            movD = false;
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            Dangxuat(this, new EventArgs());
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnGame2.Height;
            Sidepanel.Top = btnGame2.Top;
            game21.BringToFront();
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnGame3.Height;
            Sidepanel.Top = btnGame3.Top;
            game31.BringToFront();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(movD)
            {
                movX = MousePosition.X - 60;
                movY = MousePosition.Y - 60;

                this.SetDesktopLocation(movX, movY);
            }
        }
    }
}
