using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class BroneAttacker : Attacker
    {
        //Constructor
        public BroneAttacker(PictureBox MAP) : base(MAP)
        {
            Map = MAP;
        }
        public BroneAttacker(PictureBox MAP, Point vt, Direction direc)
            : base(MAP)
        {
            this.vt = vt;
            direction = direc;
            state = FigureState.weak;
            MakeAttacker();
            timeDelay = 150;
            maxHealth = 100;
            speed = 2;
            Avatar.Height = 40;
            Avatar.Width = 40;
        }
        //Method
        public override void MakeAttacker()
        {
            skin.MakeAttacker1();
        }
        public override void AttackerShoot()
        {
            if (timeDelay == 0)
            {
                Shoot();
                timeDelay = 100;
            }
            else
                timeDelay--;
        }
    }
}
