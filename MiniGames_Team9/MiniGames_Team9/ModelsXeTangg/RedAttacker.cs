using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class RedAttacker : Attacker
    {
        private bool isLast = true;
        //Constructor
        public RedAttacker(PictureBox MAP) : base(MAP)
        {
            Map = MAP;
        }
        public RedAttacker(PictureBox MAP, Point vt, Direction direc)
            : base(MAP)
        {
            this.vt = vt;
            direction = direc;
            state = FigureState.medium;
            MakeAttacker();
            speed = 5;
            timeDelay = 50;
            maxHealth = 50;
            Avatar.Height = 40;
            Avatar.Width = 40;
        }
        //Method
        public override void MakeAttacker()
        {
            if (state == FigureState.medium)
            {
                skin.MakeAttacker2Medium();
                attackerHealth = maxHealth;
            }
            else
            {
                skin.MakeAttacker2Weak();
                attackerHealth = maxHealth;
            }
            maxHealth -= maxHealth / 2;
        }
        public override void AttackerShoot()
        {
            if (timeDelay == 0)
            {
                Shoot();
                if (isLast)
                {
                    timeDelay = 70;
                    isLast = false;
                }
                else
                {
                    timeDelay = 15;
                    isLast = true;
                }
            }
            else
            {
                timeDelay--;
            }
        }
    }
}
