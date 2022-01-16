using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames_Team9
{
    class ListUsers
    {
        private static ListUsers instance;
        public static ListUsers Instance
        {
            get
            {
                if (instance == null)
                    Instance = new ListUsers();
                return instance;
            }
            set => instance = value;
        }

        List<Users> listTaiKhoan;

        internal List<Users> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }

        ListUsers()
        {
            listTaiKhoan = new List<Users>();
            listTaiKhoan.Add(new Users("thanhlinh", "123", Users.LoaiTK.User));
            listTaiKhoan.Add(new Users("admin", "123", Users.LoaiTK.Admin));
            listTaiKhoan.Add(new Users("thanhtrang", "123", Users.LoaiTK.User));
        }
    }
}
