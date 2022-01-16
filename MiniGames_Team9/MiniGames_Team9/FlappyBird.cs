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
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 10;
        int gravity = 5;
        int score = 0;
        public FlappyBird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            sun.Left -= pipeSpeed;
            // cộng điểm mỗi lần chym bay qa
            scoreText.Text = $" Score: {score}";
            // cho xuất hiện ống nước vs chìu cao và khoảng cách dc cho trước( tự gõ đại chứ hông biết j đâu :) )
            // qua sẽ dc cộng điểm
            if (pipeDown.Left < -120)
            {
                pipeDown.Left = 200;
                score++;
            }
            if (pipeUp.Left < -120)
            {
                pipeUp.Left = 300;
                score++;
            }

            // kt chym đụng dô ống nước trên,dưới,đường là game over
            if (bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                bird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                bird.Bounds.IntersectsWith(groud.Bounds))
            {
                endGame();
            }
        }
        // dk để chym rớt
        //trọng lực bằng -5
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
        // dk để chym bay lên

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "\nGame Over:))";

        }

        private void sun_Click(object sender, EventArgs e)
        {

        }
    }
}
