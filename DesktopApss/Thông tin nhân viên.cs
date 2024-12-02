using DesktopApss.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesktopApss
{
    public partial class Thông_tin_nhân_viên : Form
    {
        public Thông_tin_nhân_viên()
        {
            InitializeComponent();
        }

        private void btnMK_Click(object sender, EventArgs e)
        {
            Form_đổi_mật_khẩu f = new Form_đổi_mật_khẩu();
            f.ShowDialog();
        }
        private void LoadThongTin()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT HoNV, TenNV, GioiTinh, ChucVu, NgaySinh, NgayVaoLam, SDT, CCCD, DiaChi FROM NhanVien";
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            if (table.Rows.Count > 0)
            {
                var row = table.Rows[0];
                txtHo.Text = row["HoNV"].ToString();
                txtTen.Text = row["TenNV"].ToString();   
                txtDiaChi.Text = row["DiaChi"].ToString();
                txtSDT.Text = row["SDT"].ToString();
                txtCCCD.Text = row["CCCD"].ToString();
                txtVT.Text = row["ChucVu"].ToString();
                dtpNgaySinh.Text = row["NgaySinh"].ToString();
                dtpNgayVaoLam.Text = row["NgayVaoLam"].ToString();
                txtGioiTinh.Text = row["GioiTinh"].ToString();
            }
        }

        private void Thông_tin_nhân_viên_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
    }
}
