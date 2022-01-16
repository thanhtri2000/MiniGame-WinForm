
namespace MiniGames_Team9
{
    partial class Xetang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lbLevel = new System.Windows.Forms.Label();
            this.ptbVienTren = new System.Windows.Forms.PictureBox();
            this.ptbVienPhai = new System.Windows.Forms.PictureBox();
            this.ptbVienTrai = new System.Windows.Forms.PictureBox();
            this.ptbVienDuoi = new System.Windows.Forms.PictureBox();
            this.ptbChan2 = new System.Windows.Forms.PictureBox();
            this.ptbChan1 = new System.Windows.Forms.PictureBox();
            this.ptbDefense = new System.Windows.Forms.PictureBox();
            this.lbPause = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnResum = new System.Windows.Forms.PictureBox();
            this.MAP = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hp = new System.Windows.Forms.ProgressBar();
            this.lbHealth = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.lbDongho = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbKills = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.ptbChan3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienDuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChan3)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.LoadFrames);
            // 
            // lbLevel
            // 
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Yellow;
            this.lbLevel.Location = new System.Drawing.Point(316, 84);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(202, 59);
            this.lbLevel.TabIndex = 10;
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLevel.Visible = false;
            // 
            // ptbVienTren
            // 
            this.ptbVienTren.BackColor = System.Drawing.Color.Transparent;
            this.ptbVienTren.BackgroundImage = global::MiniGames_Team9.Properties.Resources.icon_treethree;
            this.ptbVienTren.Location = new System.Drawing.Point(-6, 35);
            this.ptbVienTren.Name = "ptbVienTren";
            this.ptbVienTren.Size = new System.Drawing.Size(781, 18);
            this.ptbVienTren.TabIndex = 11;
            this.ptbVienTren.TabStop = false;
            this.ptbVienTren.Tag = "Thep";
            // 
            // ptbVienPhai
            // 
            this.ptbVienPhai.BackColor = System.Drawing.Color.Transparent;
            this.ptbVienPhai.BackgroundImage = global::MiniGames_Team9.Properties.Resources.icon_treethree;
            this.ptbVienPhai.Location = new System.Drawing.Point(781, 35);
            this.ptbVienPhai.Name = "ptbVienPhai";
            this.ptbVienPhai.Size = new System.Drawing.Size(23, 635);
            this.ptbVienPhai.TabIndex = 14;
            this.ptbVienPhai.TabStop = false;
            this.ptbVienPhai.Tag = "Thep";
            this.ptbVienPhai.Click += new System.EventHandler(this.ptbVienPhai_Click);
            // 
            // ptbVienTrai
            // 
            this.ptbVienTrai.BackColor = System.Drawing.Color.Transparent;
            this.ptbVienTrai.BackgroundImage = global::MiniGames_Team9.Properties.Resources.icon_treethree;
            this.ptbVienTrai.Location = new System.Drawing.Point(-6, 35);
            this.ptbVienTrai.Name = "ptbVienTrai";
            this.ptbVienTrai.Size = new System.Drawing.Size(21, 635);
            this.ptbVienTrai.TabIndex = 15;
            this.ptbVienTrai.TabStop = false;
            this.ptbVienTrai.Tag = "Thep";
            // 
            // ptbVienDuoi
            // 
            this.ptbVienDuoi.BackColor = System.Drawing.Color.Transparent;
            this.ptbVienDuoi.BackgroundImage = global::MiniGames_Team9.Properties.Resources.icon_treethree;
            this.ptbVienDuoi.Location = new System.Drawing.Point(12, 632);
            this.ptbVienDuoi.Name = "ptbVienDuoi";
            this.ptbVienDuoi.Size = new System.Drawing.Size(781, 17);
            this.ptbVienDuoi.TabIndex = 16;
            this.ptbVienDuoi.TabStop = false;
            this.ptbVienDuoi.Tag = "Thep";
            // 
            // ptbChan2
            // 
            this.ptbChan2.BackColor = System.Drawing.Color.Transparent;
            this.ptbChan2.BackgroundImage = global::MiniGames_Team9.Properties.Resources.icon_treethree;
            this.ptbChan2.Location = new System.Drawing.Point(719, 274);
            this.ptbChan2.Name = "ptbChan2";
            this.ptbChan2.Size = new System.Drawing.Size(82, 18);
            this.ptbChan2.TabIndex = 43;
            this.ptbChan2.TabStop = false;
            this.ptbChan2.Tag = "Thep";
            // 
            // ptbChan1
            // 
            this.ptbChan1.BackColor = System.Drawing.Color.Transparent;
            this.ptbChan1.BackgroundImage = global::MiniGames_Team9.Properties.Resources.icon_treethree;
            this.ptbChan1.Location = new System.Drawing.Point(-12, 271);
            this.ptbChan1.Name = "ptbChan1";
            this.ptbChan1.Size = new System.Drawing.Size(81, 18);
            this.ptbChan1.TabIndex = 42;
            this.ptbChan1.TabStop = false;
            this.ptbChan1.Tag = "Thep";
            // 
            // ptbDefense
            // 
            this.ptbDefense.BackgroundImage = global::MiniGames_Team9.Properties.Resources.ic_eagle;
            this.ptbDefense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbDefense.Location = new System.Drawing.Point(370, 535);
            this.ptbDefense.Name = "ptbDefense";
            this.ptbDefense.Size = new System.Drawing.Size(63, 53);
            this.ptbDefense.TabIndex = 41;
            this.ptbDefense.TabStop = false;
            this.ptbDefense.Tag = "defense";
            // 
            // lbPause
            // 
            this.lbPause.BackColor = System.Drawing.Color.White;
            this.lbPause.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPause.ForeColor = System.Drawing.Color.Black;
            this.lbPause.Location = new System.Drawing.Point(286, 236);
            this.lbPause.Name = "lbPause";
            this.lbPause.Size = new System.Drawing.Size(193, 35);
            this.lbPause.TabIndex = 40;
            this.lbPause.Text = "PAUSE";
            this.lbPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPause.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::MiniGames_Team9.Properties.Resources.ic_quit_game;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.Location = new System.Drawing.Point(429, 274);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(50, 50);
            this.btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuit.TabIndex = 39;
            this.btnQuit.TabStop = false;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::MiniGames_Team9.Properties.Resources.ic_home_menu;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(358, 274);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 38;
            this.btnHome.TabStop = false;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnResum
            // 
            this.btnResum.BackColor = System.Drawing.Color.Transparent;
            this.btnResum.BackgroundImage = global::MiniGames_Team9.Properties.Resources.ic_resum_game;
            this.btnResum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResum.Location = new System.Drawing.Point(288, 274);
            this.btnResum.Name = "btnResum";
            this.btnResum.Size = new System.Drawing.Size(50, 50);
            this.btnResum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnResum.TabIndex = 37;
            this.btnResum.TabStop = false;
            this.btnResum.Visible = false;
            this.btnResum.Click += new System.EventHandler(this.btnResum_Click);
            // 
            // MAP
            // 
            this.MAP.BackColor = System.Drawing.Color.Black;
            this.MAP.Location = new System.Drawing.Point(15, 2);
            this.MAP.Name = "MAP";
            this.MAP.Size = new System.Drawing.Size(789, 589);
            this.MAP.TabIndex = 45;
            this.MAP.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.hp);
            this.panel1.Controls.Add(this.lbHealth);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.lbDongho);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbKills);
            this.panel1.Controls.Add(this.lbState);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 30);
            this.panel1.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(483, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(512, 1);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(226, 27);
            this.hp.TabIndex = 39;
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHealth.ForeColor = System.Drawing.Color.White;
            this.lbHealth.Location = new System.Drawing.Point(390, -1);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(79, 30);
            this.lbHealth.TabIndex = 38;
            this.lbHealth.Text = "Health:";
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Image = global::MiniGames_Team9.Properties.Resources.ic_pause;
            this.btnPause.Location = new System.Drawing.Point(778, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(32, 30);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 37;
            this.btnPause.TabStop = false;
            // 
            // lbDongho
            // 
            this.lbDongho.AutoSize = true;
            this.lbDongho.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongho.ForeColor = System.Drawing.Color.White;
            this.lbDongho.Location = new System.Drawing.Point(322, 1);
            this.lbDongho.Name = "lbDongho";
            this.lbDongho.Size = new System.Drawing.Size(22, 25);
            this.lbDongho.TabIndex = 6;
            this.lbDongho.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(281, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbKills
            // 
            this.lbKills.AutoSize = true;
            this.lbKills.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKills.ForeColor = System.Drawing.Color.White;
            this.lbKills.Location = new System.Drawing.Point(144, 0);
            this.lbKills.Name = "lbKills";
            this.lbKills.Size = new System.Drawing.Size(71, 30);
            this.lbKills.TabIndex = 2;
            this.lbKills.Text = "Kills: 0";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.Color.White;
            this.lbState.Location = new System.Drawing.Point(24, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(70, 30);
            this.lbState.TabIndex = 1;
            this.lbState.Text = "State: ";
            // 
            // ptbChan3
            // 
            this.ptbChan3.BackColor = System.Drawing.Color.Transparent;
            this.ptbChan3.BackgroundImage = global::MiniGames_Team9.Properties.Resources.icon_treethree;
            this.ptbChan3.Location = new System.Drawing.Point(382, 330);
            this.ptbChan3.Name = "ptbChan3";
            this.ptbChan3.Size = new System.Drawing.Size(37, 40);
            this.ptbChan3.TabIndex = 44;
            this.ptbChan3.TabStop = false;
            this.ptbChan3.Tag = "Thep";
            // 
            // Xetang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(803, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MAP);
            this.Controls.Add(this.ptbChan3);
            this.Controls.Add(this.ptbChan2);
            this.Controls.Add(this.ptbChan1);
            this.Controls.Add(this.ptbDefense);
            this.Controls.Add(this.lbPause);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnResum);
            this.Controls.Add(this.ptbVienDuoi);
            this.Controls.Add(this.ptbVienTrai);
            this.Controls.Add(this.ptbVienPhai);
            this.Controls.Add(this.ptbVienTren);
            this.Controls.Add(this.lbLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Xetang";
            this.Text = "Xetang";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVienDuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChan3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.PictureBox ptbVienTren;
        private System.Windows.Forms.PictureBox ptbVienPhai;
        private System.Windows.Forms.PictureBox ptbVienTrai;
        private System.Windows.Forms.PictureBox ptbVienDuoi;
        private System.Windows.Forms.PictureBox ptbChan2;
        private System.Windows.Forms.PictureBox ptbChan1;
        private System.Windows.Forms.PictureBox ptbDefense;
        private System.Windows.Forms.Label lbPause;
        private System.Windows.Forms.PictureBox btnQuit;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnResum;
        private System.Windows.Forms.PictureBox MAP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar hp;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Label lbDongho;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbKills;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.PictureBox ptbChan3;
    }
}