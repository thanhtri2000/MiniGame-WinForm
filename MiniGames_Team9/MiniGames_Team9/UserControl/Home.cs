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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlappyBird frmflappyBird = new FlappyBird();
            frmflappyBird.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarRacing frmCarRacing = new CarRacing();
            frmCarRacing.Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestMaching frmTestMaching = new TestMaching();
            frmTestMaching.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Snake frmSnake = new Snake();
            frmSnake.Show();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ZombieHunter frmzombie_Hunter = new ZombieHunter();
            frmzombie_Hunter.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puzzle frmPuzzle = new Puzzle();
            frmPuzzle.Show();
        }
    }
}
