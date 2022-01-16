using MySql.Data.MySqlClient;
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
    public partial class Score : UserControl
    {
        MySqlConnection Conn;

        MySqlCommandBuilder cmd;

        MySqlDataAdapter adap;

        DataTable mytable;
        string strconn = "Server = localhost; Database = quanlisocre; UId = root; Pwd = 01267440262Tri; Character Set=utf8";

        string query_select = "SELECT * FROM diemso";

        public Score()
        {
            InitializeComponent();
        }
        void PhanQuyen()
        {
            switch (Const.Users.LoaiTaiKhoan)
            {
                case Users.LoaiTK.User:
                    btnadd.Enabled = btndelete.Enabled = btnupdate.Enabled = false;
                    break;
            }

            txtlaoitk.Text = Const.Users.TenHienThi;
        }

        private void Score_Load(object sender, EventArgs e)
        {

            PhanQuyen();
            try

            {

                Conn = new MySqlConnection(strconn);

                Conn.Open();

                adap = new MySqlDataAdapter(query_select, Conn);

                cmd = new MySqlCommandBuilder(adap);

                mytable = new DataTable();

                adap.Fill(mytable);

                Conn.Close();

                dataGridView1.DataSource = mytable;

            }

            catch (MySqlException)

            {

                MessageBox.Show("Lỗi kết nối MySQL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TB_Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_TenNguoiChoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Conn.Open();

            string query_insert = "INSERT INTO diemso (`ID`,`UserName`, `NameGame`, `Score`) VALUES ('" + Id.Text + "','" + TB_HoTen.Text + "','" + TB_TenNguoiChoi.Text + "','" + TB_Score.Text + "')";

            MySqlCommand command = new MySqlCommand(query_insert, Conn);

            command.ExecuteNonQuery();

            Conn.Close();

            Read_Data();
        }
        private void Read_Data()

        {

            Conn.Open();

            adap = new MySqlDataAdapter(query_select, Conn);

            cmd = new MySqlCommandBuilder(adap);

            mytable = new DataTable();

            adap.Fill(mytable);

            Conn.Close();

            dataGridView1.DataSource = mytable;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Conn.Open();

            string query_edit = "UPDATE diemso SET `UserName`='" + TB_HoTen.Text + "', `NameGame`='" + TB_TenNguoiChoi.Text + "', `Score`='" + TB_Score.Text + "' WHERE ID = '" + int.Parse(Id.Text) + "'";

            MySqlCommand command = new MySqlCommand(query_edit, Conn);

            command.ExecuteNonQuery();

            Conn.Close();

            Read_Data();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Conn.Open();

            string query_delete = "DELETE FROM diemso WHERE `ID`='" + int.Parse(Id.Text) + "'";

            MySqlCommand command = new MySqlCommand(query_delete, Conn);

            command.ExecuteNonQuery();

            Conn.Close();

            Read_Data();
        }
    }
}
