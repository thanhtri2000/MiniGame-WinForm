using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames_Team9
{
    class Users
    {
        
        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }

        private string matkhau;
        public string Matkhau
        {
            get => matkhau;
            set => matkhau = value;
        }
        public enum LoaiTK
        {
            Admin,
            User

        }

        private LoaiTK loaiTaiKhoan;
        public LoaiTK LoaiTaiKhoan
        {
            get => loaiTaiKhoan;
            set => loaiTaiKhoan = value;
        }
        public string TenHienThi
        {
            get
            {
                switch (LoaiTaiKhoan)
                {
                    case LoaiTK.Admin:
                        TenHienThi = "Admin";
                        break;
                    case LoaiTK.User:
                        TenHienThi = "User";
                        break;

                }
                return tenHienThi;
            }
            set => tenHienThi = value;
        }

        private string tenHienThi;
        public Users(string tentaikhoan, string matkhau, LoaiTK loaitaikhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.Matkhau = matkhau;
            this.loaiTaiKhoan = loaitaikhoan;
        }


    }

}
