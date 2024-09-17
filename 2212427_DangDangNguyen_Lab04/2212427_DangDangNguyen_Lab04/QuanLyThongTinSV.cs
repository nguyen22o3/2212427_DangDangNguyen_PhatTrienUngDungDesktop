using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212427_DangDangNguyen_Lab04
{
    public partial class QuanLyThongTinSV : Form
    {
        QuanLySinhVien qlsv;
        public QuanLyThongTinSV()
        {
            InitializeComponent();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV,delegate (object obj1, object obj2)
            {
                return (obj2 as  SinhVien).MSSV.CompareTo(obj1.ToString());
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

        private void QuanLyThongTinSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool phai = true;
            sv.MSSV = this.mtxtMSSV.Text;
            sv.HoTen = this.txtHoTen.Text;
            if (rbNu.Checked)
                phai = false;
            sv.Phai = phai;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.lblLop.Text;
            sv.SDT = this.mtxSDT.Text;
            sv.Email = this.txtEmail.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Hinh = this.txtHinh.Text;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.Phai = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.Phai = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SDT = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoTen.Text = sv.HoTen;
            if (sv.Phai)
                this.rbNam.Checked = true;
            else
                this.rbNu.Checked = true;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cboLop.Text = sv.Lop;
            this.mtxSDT.Text = sv.SDT;
            this.txtEmail.Text = sv.Email;
            this.txtDiaChi.Text = sv.DiaChi;
            this.txtHinh.Text = sv.Hinh;
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTen);
            string phai = "Nữ";
            if (sv.Phai)
                phai = "Nam";
            lvitem.SubItems.Add(phai);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Hinh);
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
        private void btnThoat_click1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.rbNam.Checked = true;
            this.dtpNgaySinh.Value=DateTime.Now;
            this.cboLop.Text = this.cboLop.Items[0].ToString();
            this.mtxSDT.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.txtHinh.Text = "";
        }
        private void ChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            openFileDialog.Title = "Open File Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(filePath);
            }
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Xóa tất cả các mục đã chọn
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}