using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames_Team9
{
    class Spawner
    {
        //Properties
        private PictureBox map;
        private Random rd = new Random();
        Point portA = new Point(28, 52);
        Point portB = new Point(378, 52);
        Point portC = new Point(718, 52);
        int level;
        Direction direction;
        Point vt;
        //Constructor
        public Spawner() { }
        public Spawner(PictureBox map)
        {
            this.map = map;
        }
        //Method
        //Hàm khởi tạo ra 1 attacker mặc định
        public void InitAttacker(Point vt, Direction direc, List<Attacker> attackerList)
        {
            Attacker attacker = new BroneAttacker(map, vt, direc);
            attackerList.Add(attacker);
            SetTransparent(attacker.Avatar);
            Animation sa = new Animation(map, attacker);
            attacker.locked = true;
            sa.MakeSpawn(vt);
        }
        //Hàm tạo ra attacker theo cấp độ
        public void SpawnAttacker(List<Attacker> attackerList, int level, PictureBox MAP)
        {
            this.map = MAP;
            int i;
            if (CheckPort(portA) || CheckPort(portB) || CheckPort(portC))
            {
                do
                {
                    i = rd.Next(0, 100);
                    if (i % 3 == 0)
                        vt = new Point(portA.X, portA.Y);
                    else if (i % 3 == 2)
                        vt = new Point(portB.X, portB.Y);
                    else
                        vt = new Point(portC.X, portC.Y);
                } while (!CheckPort(vt));
            }
            else
            {
                do
                {
                    i = rd.Next(70, 700);
                    vt = new Point(i, 50);
                } while (!CheckPort(vt));
            }
            this.level = level;
            i = rd.Next(0, 3);
            switch (i)
            {
                case 0: direction = Direction.left; break;
                case 1: direction = Direction.right; break;
                case 2: direction = Direction.down; break;
                default: direction = Direction.down; break;
            }

            Attacker attacker;
            i = rd.Next(0, 100);
            if (level == 1)
            {
                if (i < 80)
                    attacker = new BroneAttacker(map, vt, direction);
                else
                    attacker = new RedAttacker(map, vt, direction);
            }
            else if (level == 2 || level == 3)
            {
                if (i < 60)
                    attacker = new BroneAttacker(map, vt, direction);
                else if (i < 90)
                    attacker = new RedAttacker(map, vt, direction);
                else
                    attacker = new DiamondAttacker(map, vt, direction);
            }
            else if (level == 4 || level == 5)
            {
                if (i < 70)
                    attacker = new RedAttacker(map, vt, direction);
                else
                    attacker = new DiamondAttacker(map, vt, direction);
            }
            else
            {
                attacker = new DiamondAttacker(map, vt, direction);
            }
            attackerList.Add(attacker);
            SetTransparent(attacker.Avatar);
            Animation sa = new Animation(map, attacker);
            attacker.locked = true;
            sa.MakeSpawn(vt);

        }

        //Hàm hủy bỏ tất cả attacker hiện có
        public void RemoveAttacker(List<Attacker> attacker, Attacker att)
        {
            att.skin.imleft.Dispose();
            att.skin.imright.Dispose();
            att.skin.imup.Dispose();
            att.skin.imdown.Dispose();
            att.skin.imleft = null;
            att.skin.imright = null;
            att.skin.imup = null;
            att.skin.imdown = null;
            attacker.Remove(att);
        }
        //Hàm làm trong suốt background
        public void SetTransparent(PictureBox sender)
        {
            sender.BringToFront();
            sender.BackColor = Color.Transparent;
            sender.Parent = map;
        }
        //Kiểm tra vị trí hồi sinh 
        public bool CheckPort(Point port)
        {
            PictureBox p = new PictureBox();
            p.Height = 40;
            p.Width = 40;
            p.Location = new Point(port.X, port.Y);
            foreach (Control c in map.Controls)
                if (c is PictureBox)
                {
                    if (c.Bounds.IntersectsWith(p.Bounds))
                        return false;
                }
            return true;
        }


    }
}
