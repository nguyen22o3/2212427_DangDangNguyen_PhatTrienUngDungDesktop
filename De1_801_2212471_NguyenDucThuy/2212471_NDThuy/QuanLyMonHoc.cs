using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212471_NDThuy
{
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            string connectstring = "Data Source=PC801;Initial Catalog=QLDKHP;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectstring);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = " Select MaMH, TenMH,TenCTDT,SOTC from MONHOC , CHUONGTRINHDT where MACTĐT = MACTDT";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable  dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            dgvMonHoc.DataSource = dt;  
        }
        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        void LoadCTDT ( string str)
        {
            string connectstring = "Data Source=PC801;Initial Catalog=QLDKHP;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectstring);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = " Select MaMH, TenMH,TenCTDT,SOTC from MONHOC , CHUONGTRINHDT where MACTĐT = MACTDT and TENCTDT like '%"+ str +"%'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            dgvMonHoc.DataSource = dt;
        }

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTatCa.Checked == true)
                LoadForm();
        }

        private void rd2015_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2015.Checked == true)
                LoadCTDT(rd2015.Text);
        }

        private void rd2017_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2017.Checked == true)
                LoadCTDT(rd2017.Text);
        }

        private void rd2020_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2020.Checked == true)
                LoadCTDT(rd2020.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MONHOC form = new MONHOC();
            form.ShowDialog();
            LoadForm();
        }

        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maMH = dgvMonHoc.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
                MONHOC form = new MONHOC(maMH);
                form.ShowDialog();
                LoadForm();
            }
                   
                
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private int GetSLSinhVien(string maMH)
        {
            int count = 0;
            string connectstring = "Data Source=PC801;Initial Catalog=QLDKHP;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectstring);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select count(*) from Hoc where MaMH = @MAMH";
            cmd.Parameters.AddWithValue("@MaMH", maMH);
            conn.Open();
            count = (int)cmd.ExecuteScalar();
            return count;

        }
        private void tổngSốLượngSVĐăngKýMHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count > 0)
            {
                string maMH = dgvMonHoc.SelectedRows[0].Cells["MaMH"].Value.ToString().Trim();
                int SoLuongSV = GetSLSinhVien(maMH);
                MessageBox.Show($"Có tất cả {SoLuongSV} sinh viên đã đăng ký môn học này ");
            }
        }
    }
}
