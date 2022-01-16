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
    public partial class Xetang : Form
    {
        #region Properties
        public int levelCurrent; //Level hiện tại của game
        private bool gameOver;  //Biến cho biết trạng thái của game
        private int score;      //Điểm của người chơi
        private int delay;      //Tạo đỗ trễ mất máu khi vừa game, và quản lý thời gian sinh ra zombie khi nhặt được item power
        private bool sp;        //Biến cho biết người chơi đã nhặt được item power chưa
        private double clock;
        private LevelGame levelController;        //Tạo hiệu ứng khi chuyển level game
        private Spawner spawnController;          //Tạo ra zombie mới
        private PLayer player;                    //Người chơi
        private Random rd;                        //Sinh số ngẫu nhiên
        private List<Attacker> attackers;             //List quản lí zombie hiện có  
        public static bool isFirst = true;
        private Item itemUpgrade, itemPower, itemFreeze;
        private int timeFreeze = 0;
        private int timerItem;
        private FormMenu frmMenu;
        public bool isStart = false;
        #endregion properties
        public Xetang()
        {
            InitializeComponent();
            InitAssets();
            InitMap();
        }
        public Xetang(FormMenu formLogin)
        {
            InitializeComponent();
            this.frmMenu = formLogin;
            InitAssets();
            timerGame.Stop();
            MAP.Controls.Add(ptbVienTren);
            MAP.Controls.Add(ptbVienDuoi);
            MAP.Controls.Add(ptbVienTrai);
            MAP.Controls.Add(ptbVienPhai);
            MAP.Controls.Add(ptbDefense);
            MAP.Controls.Add(ptbChan1);
            MAP.Controls.Add(ptbChan2);
            MAP.Controls.Add(ptbChan3);
        }

        #region Method
        #region Hàm khởi tạo cho các thuộc tính
        private void InitAssets()
        {
            lbLevel.Parent = MAP;
            levelController = new LevelGame(lbLevel);
            spawnController = new Spawner(MAP);

            rd = new Random();
            attackers = new List<Attacker>();
            clock = 0;
            delay = 0;
            score = 0;
            levelCurrent = 1;
            gameOver = sp = false;

        }
        private void InitMap()
        {

            InitGach80160(new Point(81, 98));
            InitGach80160(new Point(248, 98));
            InitGach80160(new Point(470, 98));
            InitGach80160(new Point(624, 98));
            InitGach80160(new Point(81, 382));
            InitGach80160(new Point(624, 382));
            InitGach12020(new Point(340, 515));
            InitGach12020(new Point(141, 313));
            InitGach12020(new Point(527, 313));
            InitGach2060(new Point(340, 535));
            InitGach2060(new Point(440, 535));
            InitGach80140(new Point(294, 323));
            InitGach80140(new Point(427, 323));
        }
        #region Hàm Tạo các bức tường gạch
        //Tạo gạch kích thước 80x160
        private void InitGach80160(Point p)
        {
            int y = p.Y;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Height = 20;
                    pic.Width = 20;
                    pic.BackgroundImage = Properties.Resources.brick2;
                    pic.Tag = "Gach";
                    pic.Location = p;
                    MAP.Controls.Add(pic);
                    pic.BringToFront();
                    p = new Point(p.X, p.Y + 20);
                }
                p = new Point(p.X + 20, y);

            }
        }
        //Tạo gạch kích thước 80x80
        private void InitGach8080(Point p)
        {
            int y = p.Y;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Height = 20;
                    pic.Width = 20;
                    pic.BackgroundImage = Properties.Resources.brick2;
                    pic.Tag = "Gach";
                    pic.Location = p;
                    MAP.Controls.Add(pic);
                    pic.BringToFront();
                    p = new Point(p.X, p.Y + 20);
                }
                p = new Point(p.X + 20, y);

            }
        }
        //Tạo gạch Kích thước 20x60
        private void InitGach2060(Point p)
        {
            int y = p.Y;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Height = 20;
                    pic.Width = 20;
                    pic.BackgroundImage = Properties.Resources.brick2;
                    pic.Tag = "Gach";
                    pic.Location = p;
                    MAP.Controls.Add(pic);
                    pic.BringToFront();
                    p = new Point(p.X, p.Y + 20);
                }
                p = new Point(p.X + 20, y);
            }
        }
        //Tạo gạch kích thước 120x20
        private void InitGach12020(Point p)
        {
            int y = p.Y;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Height = 20;
                    pic.Width = 20;
                    pic.BackgroundImage = Properties.Resources.Gach1;
                    pic.Tag = "Gach";
                    pic.Location = p;
                    MAP.Controls.Add(pic);
                    pic.BringToFront();
                    p = new Point(p.X, p.Y + 20);
                }
                p = new Point(p.X + 20, y);
            }
        }
        //Tạo gạch kích thước 80x140
        private void InitGach80140(Point p)
        {
            int y = p.Y;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Height = 20;
                    pic.Width = 20;
                    pic.BackgroundImage = Properties.Resources.brick2;
                    pic.Tag = "Gach";
                    pic.Location = p;
                    MAP.Controls.Add(pic);
                    pic.BringToFront();
                    p = new Point(p.X, p.Y + 20);
                }
                p = new Point(p.X + 20, y);
            }
        }
        #endregion Hàm Tạo các bức tường gạch
        #endregion hàm khởi tạo cho các thuộc tính
        public void InitPlayerVsAttacker()
        {
            player = new PLayer(MAP);
            player.skin.MakePlayer1();
            Animation sp = new Animation(MAP, player);
            sp.MakeSpawn(new Point(288, 548));
            player.locked = true;
            spawnController.InitAttacker(new Point(28, 52), Direction.down, attackers);
            spawnController.InitAttacker(new Point(378, 52), Direction.down, attackers);
            spawnController.InitAttacker(new Point(718, 52), Direction.down, attackers);
            spawnController.SetTransparent(player.Avatar);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver)
                return;
            if (player != null && !player.locked)
                player.PressKey(sender, e);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (gameOver)
                return;
            if (!player.locked)
                player.DropKey(sender, e);
        }
        #region Hàm khởi động game
        public void GameStart()
        {

            if (player != null)
            {
                player.Avatar.Dispose();
                player.Avatar = null;
                player = null;
            }
            for (int i = attackers.Count() - 1; i >= 0; i--)
                if (attackers[i] != null)
                {
                    attackers[i].Avatar.Dispose();
                    attackers[i].Avatar = null;
                    attackers[i] = null;
                }
            attackers = new List<Attacker>();
            foreach (Control sender in MAP.Controls)
                if (sender is PictureBox)
                {
                    if (Equals(sender.Tag, "attacker") || Equals(sender.Tag, "player") || Equals(sender.Tag, "Gach"))
                        MAP.Controls.Remove(sender);
                }
            if (isStart)
                Sound.Start();
            InitMap();
            score = 0;
            gameOver = false;
            InitPlayerVsAttacker();
            timerGame.Start();
            isFirst = false;
            itemFreeze = itemPower = itemUpgrade = null;
        }
        #endregion hàm khởi động game
        #region Nhóm hàm bắt sự kiện bàn phím
        //Sự kiện nhấn phím
        #endregion nhóm hàm bắt sự kiện bàn phím

        #region Hàm làm trong suốt background
        private void SetTransparent(PictureBox Map, PictureBox sender)
        {
            sender.BringToFront();
            sender.BackColor = Color.Transparent;
            sender.Parent = Map;
        }
        #endregion hàm làm trong suốt nền một hình ảnh

        #region Hàm hiển thị level game
        private void ShowLevelGame()
        {
            int flag = 0;
            if (score == 0)
                levelCurrent = 1;
            else if (score == 3)
                levelCurrent = 2;
            else if (score == 6)
                levelCurrent = 3;
            else if (score == 9)
                levelCurrent = 4;
            else if (score == 12)
                levelCurrent = 5;
            else if (score == 15)
                levelCurrent = 6;
            else if (score == 17)
                levelCurrent = 7;
            else
                flag = 1;
            if (flag == 0 && (levelCurrent != levelController.level))
            {
                levelController.level = levelCurrent;
                levelController.Animation();
            }
        }
        #endregion hàm hiển thị level game
        #region Sự kiện khung hình load liên tục sau mỗi 20 ms
        private void LoadFrames(object sender, EventArgs e)
        {
            ShowLevelGame();
            delay++;
            clock += 0.02;
            lbDongho.Text = Math.Round(clock, 2).ToString();
            if (score == 400)
            {
                timerGame.Stop();
                Sound.GameOver();
                gameOver = true;
                levelController.level = 8;
                levelController.Animation();
            }
            if (player.playerHealth > 1)
                hp.Value = Convert.ToInt32(player.playerHealth);
            else
            {
                if (player.state == FigureState.weak)
                {
                    timerGame.Stop();
                    Sound.GameOver();
                    gameOver = true;
                    frmMenu.UpdateScore(score, clock);
                    ShowMenuForm();
                    isStart = true;
                    isFirst = true;
                }
                else
                {
                    player.DownState();
                }
            }
            lbState.Text = "State: " + player.state.ToString();
            lbKills.Text = "Kills: " + score.ToString();
            if (player.playerHealth < 20)
                hp.ForeColor = Color.Red;
            player.MoveAvatar(sender, e);
            //Xử lí va chạm 
            foreach (Control x in MAP.Controls)
            {
                #region Hòm tiếp tế va chạm với người
                //Xử lý va chạm hòm tiếp tế và đạn ra ngoài màn hình
                if (x is PictureBox && Equals(x.Tag, "freeze"))
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Avatar.Bounds))
                    {
                        FreezeItem am = (FreezeItem)itemFreeze;
                        timeFreeze = 100;
                        //bug
                        MAP.Controls.Remove((PictureBox)x);
                        am.Destroy();
                    }
                }
                //Va chạm item nâng cấp
                else if (x is PictureBox && Equals(x.Tag, "upgrade"))
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Avatar.Bounds))
                    {
                        UpgradeItem ug = (UpgradeItem)itemUpgrade;
                        MAP.Controls.Remove((PictureBox)x);

                        player.bulletLevel++;
                        player.dame += 2;
                        if (player.bulletLevel == 5)
                        {
                            player.UpState();
                        }
                        ug.Destroy();
                    }
                }
                //Va chạm item power
                else if (x is PictureBox && Equals(x.Tag, "power"))
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Avatar.Bounds))
                    {
                        PowerItem pw = (PowerItem)itemPower;
                        pw.Destroy();
                        Attacker at;
                        for (int i = 2; i >= 0; i--)
                        {
                            at = attackers[i];
                            sp = true;
                            score++;
                            MAP.Controls.Remove(at.Avatar);
                            if (at.Avatar.Tag != null)
                            {
                                ExplosionAttacker(new Point(at.Avatar.Left, at.Avatar.Top));
                                spawnController.RemoveAttacker(attackers, at);
                            }
                            delay = 110;
                        }

                    }
                }
                #endregion
                #region Đạn va chạm với đạn
                if (x is PictureBox && Equals(x.Tag, "bulletRed") || Equals(x.Tag, "bulletOrange"))
                {
                    foreach (Control z in MAP.Controls)
                        if (z is PictureBox && Equals(z.Tag, "bulletOrange") && x != z)
                        {
                            if (((PictureBox)x).Bounds.IntersectsWith(((PictureBox)z).Bounds))
                            {
                                MAP.Controls.Remove((PictureBox)x);
                                MAP.Controls.Remove((PictureBox)z);
                            }
                        }
                        else if (z is PictureBox && Equals(z.Tag, "Thep"))
                        {
                            if (((PictureBox)x).Bounds.IntersectsWith(((PictureBox)z).Bounds))
                                MAP.Controls.Remove(x);
                        }
                        else if (z is PictureBox && Equals(z.Tag, "defense"))
                        {
                            if (((PictureBox)x).Bounds.IntersectsWith(((PictureBox)z).Bounds))
                            {
                                timerGame.Stop();
                                Sound.AttackerBurst();
                                ExplosionAttacker(new Point(z.Location.X, z.Location.Y));
                                gameOver = true;
                                MAP.Controls.Remove(x);
                                frmMenu.UpdateScore(score, clock);
                                ShowMenuForm();
                                isStart = true;
                                isFirst = true;
                            }
                        }
                        else if (z is PictureBox && Equals(z.Tag, "Gach"))
                        {
                            if (((PictureBox)x).Bounds.IntersectsWith(((PictureBox)z).Bounds))
                            {
                                MAP.Controls.Remove(x);
                                MAP.Controls.Remove(z);
                            }
                        }
                }
                #endregion Đạn va chạm với đạn
                #region Đạn của attacker va chạm với người
                if (x is PictureBox && Equals(x.Tag, "bulletOrange"))
                {
                    PictureBox bulletOrange = x as PictureBox;
                    if (x.Bounds.IntersectsWith(player.Avatar.Bounds))
                    {
                        if (x.Bounds.IntersectsWith(player.Avatar.Bounds))
                            if (levelCurrent == 1)
                                player.playerHealth -= 10;
                            else if (levelCurrent == 2)
                                player.playerHealth -= 15;
                            else if (levelCurrent == 3)
                                player.playerHealth -= 20;
                            else if (levelCurrent == 4)
                                player.playerHealth -= 25;
                            else if (levelCurrent == 5)
                                player.playerHealth -= 30;
                            else
                                player.playerHealth -= 35;
                        MAP.Controls.Remove(x);
                    }

                }
                #endregion đạn của attacker va chạm với người
                if (x is PictureBox && Equals(x.Tag, "attacker"))
                {
                    foreach (Control y in MAP.Controls)
                    {
                        #region attacker va chạm với đạn
                        if (y is PictureBox && Equals(y.Tag, "bulletRed") && (x is PictureBox && Equals(x.Tag, "attacker")))
                        {
                            if (x.Bounds.IntersectsWith(y.Bounds))
                            {
                                CollisionHandle((PictureBox)y, (PictureBox)x);
                            }
                        }
                        #endregion

                    }
                }
            }
            if (timeFreeze == 0)
                MoveAttackers();
            else
                timeFreeze--;
            timerItem++;
            //Sau mỗi 4 giây sẽ thả item
            if (timerItem > 200)
            {
                timerItem = 0;
                InitItem();
            }
            //Sau thời gian 59*20 s kể từ nhặt được item power tiến hành tạo zombie mới
            if (delay > 169)
            {
                if (sp == true)
                {
                    spawnController.InitAttacker(new Point(28, 52), Direction.down, attackers);
                    spawnController.InitAttacker(new Point(378, 52), Direction.down, attackers);
                    spawnController.InitAttacker(new Point(718, 52), Direction.down, attackers);
                    sp = false;
                    delay = 110;
                }
            }

        }
        #endregion Sự kiện khung hình load liên tục sau mỗi 20 ms
        #region tạo độ mất máu của attacker theo level của game
        private void CollisionHandle(PictureBox bullet, PictureBox zombie)
        {
            Attacker attackerCurrent = null;
            foreach (Attacker at in attackers)
                if (at.Avatar == zombie)
                {
                    attackerCurrent = at;
                    break;
                }
            if (attackerCurrent != null)
            {
                attackerCurrent.attackerHealth -= player.dame - levelCurrent * 10;
                if (attackerCurrent.attackerHealth <= 0)
                {
                    if (attackerCurrent.state == FigureState.weak)
                    {
                        score++;
                        Sound.AttackerBurst();
                        bullet.Dispose();
                        bullet = null;
                        zombie.Tag = null;
                        MAP.Controls.Remove(zombie);
                        MAP.Controls.Remove(bullet);
                        ExplosionAttacker(new Point(zombie.Left, zombie.Top));
                        spawnController.RemoveAttacker(attackers, attackerCurrent);
                        spawnController.SpawnAttacker(attackers, levelCurrent, MAP);
                    }
                    else
                    {
                        bullet.Dispose();
                        bullet = null;
                        MAP.Controls.Remove(bullet);
                        attackerCurrent.DownState();

                    }
                }
                else
                {
                    bullet.Dispose();
                    bullet = null;
                    MAP.Controls.Remove(bullet);
                }
            }
        }
        #endregion tạo độ mất máu của attacker theo level của game
        #region Hàm tạo ra animation khi attacker bị tiêu diệt
        private void ExplosionAttacker(Point vt)
        {
            Animation animation = new Animation(MAP);
            animation.MakeAnimation(vt);
        }
        #endregion hàm tạo ra animation khi zombie bị tiêu diệt
        #region Nhóm hàm di chuyển attacker
        //+Tạo tốc độ cho attackers theo level
        private void MakeSpeedForAttackers()
        {
            //int speed;
            //if (levelCurrent == 5 || levelCurrent == 6)
            //    speed = 2;
            //else if (levelCurrent == 7)
            //    speed = 3;
            //else
            //    speed = 1;
            //foreach (Attacker at in attackers)
            //    at.IncreaseSpeed(speed);
        }
        //+Thực hiện di chuyển Attackers
        int l = 0;
        private void MoveAttackers()
        {
            MakeSpeedForAttackers();

            foreach (Attacker at in attackers)
            {
                if (at.locked == false)
                {
                    at.direction = SelectDirectAttakerNextMove(at);
                    at.MoveEnemy();
                }
            }
        }
        #endregion nhóm hàm di chuyển attacker
        #region Hàm chức năng
        //Chọn hướng đi cho attacker
        private Direction SelectDirectAttakerNextMove(Attacker att)
        {
            bool flag = true;
            Direction direct = att.direction;
            int i = rd.Next(0, 100);
            if (i > 0)
            {
                foreach (Control c in MAP.Controls)
                    if (c is PictureBox && c != att.Avatar)
                    {
                        if (Equals(c.Tag, "Thep") || Equals(c.Tag, "attacker") || Equals(c.Tag, "Gach") || Equals(c.Tag, "Spawn"))
                        {
                            PictureBox p = NextLocationFigure(att, att.direction, att.speed);
                            if (c.Bounds.IntersectsWith(p.Bounds))
                                flag = false;
                        }
                        else if (Equals(c.Tag, "Avatar") || Equals(c.Tag, "defense"))
                        {
                            PictureBox p = NextLocationFigure(att, att.direction, att.speed);
                            if (c.Bounds.IntersectsWith(p.Bounds))
                            {
                                Attacker.isStand = true;
                                return direct;
                            }
                            else
                            {
                                Attacker.isStand = false;
                            }
                        }
                    }
                if (flag)
                    return direct;
            }
            int index = 0;
            List<Direction> direction = new List<Direction>(3);
            if (direct != Direction.up) direction.Add(Direction.up);
            if (direct != Direction.left) direction.Add(Direction.left);
            if (direct != Direction.down) direction.Add(Direction.down);
            if (direct != Direction.right) direction.Add(Direction.right);

            do
            {
                flag = true;
                if (direction.Count > 0)
                {
                    index = rd.Next(direction.Count);
                    foreach (Control c in this.MAP.Controls)
                        if (c is PictureBox && c != att.Avatar)
                        {
                            if (Equals(c.Tag, "Avatar") || Equals(c.Tag, "Thep") || Equals(c.Tag, "attacker") || Equals(c.Tag, "defense") || Equals(c.Tag, "Gach") || Equals(c.Tag, "Spawn"))
                            {
                                PictureBox p = NextLocationFigure(att, direction[index], att.speed);
                                if (c.Bounds.IntersectsWith(p.Bounds))
                                {
                                    flag = false;
                                    direction.RemoveAt(index);
                                    break;
                                }
                            }
                        }
                }
                else
                    return Direction.stand;
            } while (!flag);
            return direction[index];
        }
        private PictureBox NextLocationFigure(Figure fig, Direction direct, int speed)
        {
            PictureBox p = new PictureBox();
            p.Size = fig.Avatar.Size;
            p.Location = fig.Avatar.Location;
            if (direct == Direction.down)
            {
                p.Location = new Point(fig.Avatar.Location.X, fig.Avatar.Location.Y + speed + 1);
            }
            else if (direct == Direction.up)
            {
                p.Location = new Point(fig.Avatar.Location.X, fig.Avatar.Location.Y - speed - 1);
            }
            else if (direct == Direction.left)
            {
                p.Location = new Point(fig.Avatar.Location.X - speed - 1, fig.Avatar.Location.Y);
            }
            else if (direct == Direction.right)
            {
                p.Location = new Point(fig.Avatar.Location.X + speed + 1, fig.Avatar.Location.Y);
            }
            return p;
        }
        #region Hàm Khởi tạo item
        private void InitItem()
        {
            int i = rd.Next(0, 100);
            if (i < 10 && levelCurrent >= 2)
                itemFreeze = new FreezeItem(MAP);
            else if (i > 70 && levelCurrent >= 3)
                itemPower = new PowerItem(MAP);
            else if (i < 50)
                itemUpgrade = new UpgradeItem(MAP);
            if (itemUpgrade != null)
                itemUpgrade.CreateItem(MAP);
            if (itemFreeze != null)
                itemFreeze.CreateItem(MAP);
            if (itemPower != null)
                itemPower.CreateItem(MAP);


        }

        private void ptbVienPhai_Click(object sender, EventArgs e)
        {

        }

        private void btnResum_Click(object sender, EventArgs e)
        {
            Sound.ClickSound();
            btnPause.Enabled = true;
            ShowGameOver();
            timerGame.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Sound.ClickSound();
            btnPause.Enabled = true;
            ShowGameOver();
            frmMenu.Show();
            this.Hide();
            isStart = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Sound.ClickSound();
            if (MessageBox.Show("Bạn muốn thoát chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
        #endregion hàm Khởi tạo item

        #endregion Hàm chức năng

        #region Hàm hiển thị form menu
        private void ShowMenuForm()
        {
            frmMenu.ShowFormEnd();
            frmMenu.Show();
        }
        #endregion hàm hiện thị form menu
        #region Nhóm hàm pause game
        public void ShowGameOver()
        {
            lbPause.Visible = !lbPause.Visible;
            btnResum.Visible = !btnResum.Visible;
            btnHome.Visible = !btnHome.Visible;
            btnQuit.Visible = !btnQuit.Visible;
        }
    }
     #endregion
     #endregion Method
}
