using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class UpgradeItem : Item
    {
        //Constructor
        public UpgradeItem() { }
        public UpgradeItem(PictureBox map) : base(map)
        {
            item.Image = Properties.Resources.upgrade;
            item.Tag = "upgrade";
            timeToDes = 15;
        }
        //Method
        public override void CreateItem(PictureBox Map)
        {
            base.CreateItem(Map);
        }
    }
}
