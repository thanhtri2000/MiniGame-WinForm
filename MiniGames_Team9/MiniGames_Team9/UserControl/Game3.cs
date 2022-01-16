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
    public partial class Game3 : UserControl
    {
        public Game3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZombieHunter frmzombie_Hunter = new ZombieHunter();
            frmzombie_Hunter.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CarRacing frmCarRacing = new CarRacing();
            frmCarRacing.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MayBay frmMB = new MayBay();
            frmMB.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuestionGame3 frmQ3 = new QuestionGame3();
            frmQ3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu frmM = new FormMenu();
            frmM.Show();
        }
    }
}
