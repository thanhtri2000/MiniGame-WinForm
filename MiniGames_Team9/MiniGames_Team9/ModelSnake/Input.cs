using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class Input
    {
        
        //Tải danh sách các nút Bàn phím có sẵn
        private static Hashtable keyTable = new Hashtable();

        
        //Thực hiện kiểm tra xem một nút cụ thể có được nhấn hay không
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Phát hiện nếu một nút bàn phím được nhấn
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
