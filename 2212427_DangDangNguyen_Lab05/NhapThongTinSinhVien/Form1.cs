using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapThongTinSinhVien
{
    public partial class Form1 : Form
    {
        QuanLySinhVien qlsv;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMSSV_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaChiLienLac_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool GioiTinh = true;
            List<string> monhoc = new List<string>();
            sv.MSSV=this.txtMSSV.Text;
            sv.HoVaTenLot=this.txtHoTen.Text;
            sv.Ten=this.txtTen.Text;
            if(rbNu.Checked)
            {
                GioiTinh=false;
            }
            sv.GioiTinh = GioiTinh;
            sv.Lop = this.cbLop.Text;
            sv.SoCMND=this.txtSoCMND.Text;
            sv.SoDT=this.mtbSoDT.Text;
            sv.DiaChiLienLac=this.txtDiaChiLienLac.Text;
            for (int i = 0; i < this.clbMonHocDangKy.Items.Count; i++)
                if (clbMonHocDangKy.GetItemChecked(i))
                    monhoc.Add(clbMonHocDangKy.Items[i].ToString());
            sv.MonHoc = monhoc;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            return sv;
        }
        private void ThemSV(SinhVien sv)
        {

        }
        private void LoadListView()
        {
            this.listView1.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
