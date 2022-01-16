using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{

    abstract class Enemy : Figure
    {
        //Properties
        public Direction direction;
        public int speed = 1;
        //Constructor
        public Enemy() { }
        public Enemy(PictureBox MAP)
        {
            this.Map = MAP;
        }
        //Method
        //Di chuyển Enemy
        public abstract void MoveEnemy();
        //Hàm tăng tộc độ của enemy theo level
        public void IncreaseSpeed(int level)
        {
            speed = level;
        }
        //Hàm thay đổi độ cứng của enemy
    }

}
