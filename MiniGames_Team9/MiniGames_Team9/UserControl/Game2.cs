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
    public partial class Game2 : UserControl
    {
        public Game2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FlappyBird frmflappyBird = new FlappyBird();
            frmflappyBird.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Snake frmSnake = new Snake();
            frmSnake.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestMaching frmTestMaching = new TestMaching();
            frmTestMaching.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puzzle frmPuzzle = new Puzzle();
            frmPuzzle.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QuestionGame3 frmQ = new QuestionGame3();
            frmQ.Show();
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            QuestionGame2 frmQ = new QuestionGame2();
            frmQ.Show();
        }
    }
}
