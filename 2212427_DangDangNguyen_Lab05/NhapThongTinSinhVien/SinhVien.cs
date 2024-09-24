using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapThongTinSinhVien
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoVaTenLot { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh {  get; set; }
        public string Lop {  get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChiLienLac { get; set; }
        public List<string> MonHoc { get; set; }
        public SinhVien()
        {
            MonHoc=new List<string>();
        }
        public SinhVien(string mssv,string hovatenlot,string ten,bool gioitinh,DateTime ngaysinh,string lop,string socmnd,string sodt,string diachilienlac,List<string> monhoc)
        {
            this.MSSV=mssv;
            this.HoVaTenLot=hovatenlot;
            this.Ten=ten;
            this.GioiTinh=gioitinh;
            this.NgaySinh=ngaysinh;
            this.Lop=lop;
            this.SoCMND=socmnd;
            this.SoDT=sodt;
            this.DiaChiLienLac=diachilienlac;
            this.MonHoc=monhoc;
        }
    }
}
