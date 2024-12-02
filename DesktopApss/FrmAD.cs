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

namespace DesktopApss
{
    public partial class FrmAD : Form
    {
        public FrmAD()
        {
            InitializeComponent();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new Quản_lý_nhân_viên();
            from.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new Quản_lý_khách_hàng();
            from.ShowDialog();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new Quản_ly_kho();
            from.ShowDialog();
        }

        private void formBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new frmBangDia();
            from.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new Màn_Hình_Đăng_Nhập();
            from.ShowDialog();
            this.Close();
        }
        private void LoadData()
        {
            // Chuỗi kết nối sử dụng chuỗi kết nối mới của bạn
            var connString = Utilities.connectionString;


            // Truy vấn SQL để lấy dữ liệu hóa đơn
            string query = @"
             
             SELECT HD.MaHD, HD.NgayThue, HD.HanThue,HD.NgayNhan, HD.Tong, 
       
             SUM(CTHD.GiamGia) AS GiamGia, 
             SUM(CTHD.PhatSinh) AS PhatSinh
             FROM HoaDon HD
             LEFT JOIN ChiTietHoaDon CTHD ON HD.MaHD = CTHD.MaHD
             WHERE YEAR(HD.NgayThue) = @Year AND MONTH(HD.NgayThue) = @Month
             GROUP BY HD.MaHD, HD.NgayThue, HD.HanThue,HD.NgayNhan, HD.Tong";

            // Kết nối đến cơ sở dữ liệu và thực thi truy vấn
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Year", dtpThang.Value.Year);
                da.SelectCommand.Parameters.AddWithValue("@Month", dtpThang.Value.Month);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị dữ liệu vào DataGridView
                dgvBaoCao.DataSource = dt;

                // Tính tổng các thông số và cập nhật các Label
                CalculateTotals(dt);
            }
        }
        private void CalculateTotals(DataTable dt)
        {
            int tongDonHang = dt.Rows.Count;
            int tongDoanhThu = 0;
            int tongGiamGia = 0;
            int tongPhatSinh = 0;

            foreach (DataRow row in dt.Rows)
            {
                tongDoanhThu += Convert.ToInt32(row["Tong"]);
                tongGiamGia += Convert.ToInt32(row["GiamGia"]);
                tongPhatSinh += Convert.ToInt32(row["PhatSinh"]);
            }

            // Cập nhật các Label với tổng giá trị
            lblTongDonHang.Text = "Tổng đơn hàng: " + tongDonHang + " đồng";
            lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu + " đồng";
            lblTongGiamGia.Text = "Tổng giảm giá: " + tongGiamGia + " đồng";
            lblTongPhatSinh.Text = "Tổng phát sinh: " + tongPhatSinh + " đồng";
        }

    }
}
