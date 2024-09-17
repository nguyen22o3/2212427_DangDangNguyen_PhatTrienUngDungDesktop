using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212427_DangDangNguyen_Lab04
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh {  get; set; }
        public DateTime NgaySinh {  get; set; }
        public bool Phai { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public SinhVien() 
        {

        }
        public SinhVien(string mssv, string hoTen, string email, string diaChi, string hinh, DateTime ngaySinh, bool phai, string lop, string sDT)
        {
            this.MSSV = mssv;
            this.HoTen = hoTen;
            this.Email = email;
            this.DiaChi = diaChi;
            this.Hinh = hinh;
            this.NgaySinh = ngaySinh;
            this.Phai = phai;
            this.Lop = lop;
            this.SDT = sDT;
        }
    }
}
