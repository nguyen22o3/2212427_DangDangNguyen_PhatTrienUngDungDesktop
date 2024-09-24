using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapThongTinSinhVien
{
    public delegate int SoSanh(object sv1, object sv2);
    internal class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        public void Them(SinhVien SV)
        {
            this.DanhSach.Add(SV);
        }
        public bool CapNhat(SinhVien svcapnhat, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svcapnhat;
                    kq = true;
                    break;
                }
            return kq;
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        public void DocTuFile()
        {
            string filename = "DSSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.MSSV = s[0];
                sv.HoVaTenLot = s[1];
                sv.Ten = s[2];
                sv.GioiTinh = false;
                if (s[3] == "1")
                {
                    sv.GioiTinh = true;
                }
                sv.NgaySinh = DateTime.Parse(s[4]);
                sv.Lop = s[5];
                sv.SoCMND = s[6];
                sv.SoDT = s[7];
                sv.DiaChiLienLac = s[8];
                string[] monhoc = s[9].Split(',');
                foreach (string c in monhoc)
                    sv.MonHoc.Add(c);
                this.Them(sv);
            }
        }
    }
}
