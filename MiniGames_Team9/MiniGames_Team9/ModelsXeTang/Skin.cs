using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MiniGames_Team9
{
    class Skin
    {
        //Properties
        public Image imleft;      //Ảnh khi người chơi di chuyển qua trái
        public Image imright;     //Ảnh khi người chơi di chuyển qua phải
        public Image imup;        //Ảnh khi người chơi di chuyển lên trên
        public Image imdown;     //Ảnh khi người chơi di chuyển xuống dưới
        public string[] arrSkin = new string[5];
        //Constructor
        public Skin() { }
        public Skin(string[] s)
        {
            arrSkin = s;
        }
        //Method
        //Hàm tạo ảnh nhân vật theo 4 hướng
        public void MakeAvatar()
        {
            imleft = Image.FromFile(arrSkin[0]);
            imright = Image.FromFile(arrSkin[1]);
            imup = Image.FromFile(arrSkin[2]);
            imdown = Image.FromFile(arrSkin[3]);
        }
        public void MakeSkin(string sleft, string sright, string sup, string sdown)
        {
            imleft = Image.FromFile(sleft);
            imright = Image.FromFile(sright);
            imup = Image.FromFile(sup);
            imdown = Image.FromFile(sdown);
        }
        //Tạo zombie
        //+Hàm lấy hình ảnh Attacker thứ nhất
        public void MakeAttacker1()
        {
            imleft = Properties.Resources.attacker1left1;
            imright = Properties.Resources.attacker1right1;
            imup = Properties.Resources.attacker1up1;
            imdown = Properties.Resources.attacker1down1;
        }
        //+Hàm lấy hình ảnh RedAttacker medium
        public void MakeAttacker2Medium()
        {
            imleft = Properties.Resources.attacker2left1;
            imright = Properties.Resources.attacker2right1;
            imup = Properties.Resources.attacker2up1;
            imdown = Properties.Resources.attacker2down1;
        }
        //+Hàm lấy hình ảnh RedAttacker weak
        public void MakeAttacker2Weak()
        {
            imleft = Properties.Resources.attacker2weakleft1;
            imright = Properties.Resources.attacker2weakright1;
            imup = Properties.Resources.attacker2weakup1;
            imdown = Properties.Resources.attacker2weakdown1;
        }
        //+Hàm lấy hình ảnh DiamondAttacker strong
        public void MakeAttacker3Strong()
        {
            imleft = Properties.Resources.attacker3left;
            imright = Properties.Resources.attacker3right;
            imup = Properties.Resources.attacker3up;
            imdown = Properties.Resources.attacker3down;
        }
        //+Hàm lấy hình ảnh DiamondAttacker medium
        public void MakeAttacker3Medium()
        {
            imleft = Properties.Resources.attacker3mediumleft;
            imright = Properties.Resources.attacker3mediumright;
            imup = Properties.Resources.attacker3mediumup;
            imdown = Properties.Resources.attacker3mediumdown;
        }
        //+Hàm lấy hình ảnh DiamondAttacker weak
        public void MakeAttacker3Weak()
        {
            imleft = Properties.Resources.attacker3weakleft;
            imright = Properties.Resources.attacker3weakright;
            imup = Properties.Resources.attacker3weakup;
            imdown = Properties.Resources.attacker3weakdown;
        }

        //Tạo nhân vật
        //+Hàm lấy hình ảnh player thứ nhất
        public void MakePlayer1()
        {
            imleft = Properties.Resources.player1left1;
            imright = Properties.Resources.player1right1;
            imup = Properties.Resources.player1up1;
            imdown = Properties.Resources.player1down1;
        }
        //+Hàm lấy hình ảnh player thứ hai
        public void MakePlayer2()
        {
            imleft = Properties.Resources.player2left;
            imright = Properties.Resources.player2right;
            imup = Properties.Resources.player2up;
            imdown = Properties.Resources.player2down;
        }
        //+hàm lấy hình ảnh super player
        public void MakeSuperPlayer()
        {
            imleft = Properties.Resources.player3left;
            imright = Properties.Resources.player3right;
            imup = Properties.Resources.player3up;
            imdown = Properties.Resources.player3down;
        }
    }
}
