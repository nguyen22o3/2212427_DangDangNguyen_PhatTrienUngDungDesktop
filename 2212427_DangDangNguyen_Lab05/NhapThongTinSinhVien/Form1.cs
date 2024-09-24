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
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool GioiTinh = true;
            List<string> monhoc = new List<string>();
            sv.MSSV = this.txtMSSV.Text;
            sv.HoVaTenLot = this.txtHoTen.Text;
            sv.Ten = this.txtTen.Text;
            if (rbNu.Checked)
            {
                GioiTinh = false;
            }
            sv.GioiTinh = GioiTinh;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cbLop.Text;
            sv.SoCMND = this.txtSoCMND.Text;
            sv.SoDT = this.mtbSoDT.Text;
            sv.DiaChiLienLac = this.txtDiaChiLienLac.Text;
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
            sv.HoVaTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[3].Text == "Nam")
                sv.GioiTinh = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[4].Text);
            sv.Lop = lvitem.SubItems[5].Text;
            sv.SoCMND = lvitem.SubItems[6].Text;
            sv.SoDT = lvitem.SubItems[7].Text;
            sv.DiaChiLienLac = lvitem.SubItems[8].Text;
            List<string> monhoc = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string t in s)
                monhoc.Add(t);
            sv.MonHoc = monhoc;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.txtMSSV.Text = sv.MSSV;
            this.txtHoTen.Text = sv.HoVaTenLot;
            this.txtTen.Text = sv.Ten;
            if (sv.GioiTinh)
                this.rbNam.Checked = true;
            else
                this.rbNu.Checked = true;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbLop.Text = sv.Lop;
            this.txtSoCMND.Text = sv.SoCMND;
            this.mtbSoDT.Text = sv.SoDT;
            this.txtDiaChiLienLac.Text = sv.DiaChiLienLac;
            for (int i = 0; i < this.clbMonHocDangKy.Items.Count; i++)
                this.clbMonHocDangKy.SetItemChecked(i, false);
            foreach (string s in sv.MonHoc)
            {
                for (int i = 0; i < this.clbMonHocDangKy.Items.Count;
                i++)
                    if
                    (s.CompareTo(this.clbMonHocDangKy.Items[i]) == 0)
                        this.clbMonHocDangKy.SetItemChecked(i,
                        true);
            }
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoVaTenLot);
            lvitem.SubItems.Add(sv.Ten);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SoCMND);
            lvitem.SubItems.Add(sv.SoDT);
            lvitem.SubItems.Add(sv.DiaChiLienLac);
            string monhoc = "";
            foreach (string s in sv.MonHoc)
                monhoc += s + ",";
            monhoc = monhoc.Substring(0, monhoc.Length - 1);
            lvitem.SubItems.Add(monhoc);
            this.listView1.Items.Add(lvitem);
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
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV,
            delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.listView1.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =
                this.listView1.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.CapNhat(sv, sv.MSSV, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}