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
    public partial class Login : Form
    {
        List<Users> listTaiKhoan = ListUsers.Instance.ListTaiKhoan;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

          

        }
        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as frmMain).Thoat = false;
            (sender as frmMain).Close();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
          
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].Matkhau)
                {
                    Const.Users = listTaiKhoan[i];
                    return true;
                }
            }
            return false;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtUser.Text, txtPass.Text))
            {
                frmMain m = new frmMain();
                MessageBox.Show
                ("Logged in Successfully");
                m.Show();
                this.Hide();
                m.Dangxuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("Login failed", "Error");
                txtUser.Focus();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Application.Exit();
        }
    }
}
