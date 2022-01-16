using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class FreezeItem : Item
    {
        //Constructor
        public FreezeItem() { }
        public FreezeItem(PictureBox map)
            : base(map)
        {
            item.Image = Properties.Resources.freeze;
            item.Tag = "freeze";
            timeToDes = 15;
        }
        //Method
        public override void CreateItem(PictureBox Map)
        {
            base.CreateItem(Map);
        }
    }
}
