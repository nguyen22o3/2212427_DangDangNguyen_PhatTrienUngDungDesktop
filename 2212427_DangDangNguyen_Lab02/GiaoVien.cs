using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212427_DangDangNguyen_Lab02
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maSo, string hoten, DateTime ngaysinh, DanhMucMonHoc ds, string gt, string[] nn, string sdt, string mail)
        {
            MaSo = maSo;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            this.dsMonHoc = ds;
            GioiTinh = gt;
            NgoaiNgu = nn;
            SoDT = sdt;
            Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ tên:" + HoTen + "\n"
                + "Ngày sinh:" + NgaySinh.ToString() + "\n"
                + "Giới tính:" + GioiTinh + "\n"
                + "Số ĐT:" + SoDT + "\n"
                + "Mail:" + Mail + "\n";
                string sngoaingu = "Ngoại  Ngữ:";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string Monday = "Danh sách môn dạy";
            foreach(MonHoc nh in dsMonHoc.ds)
                Monday += nh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }
    }
}
