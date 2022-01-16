using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniGames_Team9
{
    class DiamondAttacker : Attacker
    {
        //Constructor
        public DiamondAttacker(PictureBox MAP) : base(MAP)
        {
            Map = MAP;
        }
        public DiamondAttacker(PictureBox MAP, Point vt, Direction direc)
            : base(MAP)
        {
            this.vt = vt;
            direction = direc;
            state = FigureState.strong;
            MakeAttacker();
            speed = 3;
            timeDelay = 50;
            maxHealth = 150;
            Avatar.Height = 40;
            Avatar.Width = 40;
        }
        //Method
        public override void MakeAttacker()
        {
            if (state == FigureState.strong)
                skin.MakeAttacker3Strong();
            else if (state == FigureState.medium)
                skin.MakeAttacker3Medium();
            else
                skin.MakeAttacker3Weak();
            attackerHealth -= maxHealth / 2;
        }
        public override void AttackerShoot()
        {
            if (timeDelay == 0)
            {
                Shoot();
                timeDelay = 55;
            }
            else
                timeDelay--;
        }
    }
}
