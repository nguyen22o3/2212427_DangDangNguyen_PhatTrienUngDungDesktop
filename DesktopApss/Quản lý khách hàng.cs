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
    public partial class Quản_lý_khách_hàng : Form
    {
        public Quản_lý_khách_hàng()
        {
            InitializeComponent();
        }

        private void Quản_lý_khách_hàng_Load(object sender, EventArgs e)
        {
            LayDSKhachHang();
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
        }
        public void LayDSKhachHang()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT MaKH, HoKH, TenKH, GioiTinh, DiaChi, SDT, CCCD, Notes FROM KhachHang";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            dgvDSKH.DataSource = table;
        }
        private void dgvDSKH_Click_1(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                var hangDangChon = dgvDSKH.SelectedRows[0];// Lấy hàng đầu tiên
                txtMaKH.Text = hangDangChon.Cells[0].Value.ToString();
                txtHo.Text = hangDangChon.Cells[1].Value.ToString();
                txtTen.Text = hangDangChon.Cells[2].Value.ToString();
                cbbGioiTinh.Text = hangDangChon.Cells[3].Value.ToString();
                txtDiaChi.Text = hangDangChon.Cells[4].Value.ToString();
                mtxtSDT.Text = hangDangChon.Cells[5].Value.ToString();
                txtCCCD.Text = hangDangChon.Cells[6].Value.ToString();
                txtNotes.Text = hangDangChon.Cells[7].Value.ToString();
            }
        }
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHo.Clear();
            txtTen.Clear();
            //cbbGioiTinh.Clear();
            txtDiaChi.Clear();
            mtxtSDT.Clear();
            txtCCCD.Clear();
            txtNotes.Clear();
        }
        private void tsmXoa_Click(object sender, EventArgs e)
        {
            var connString = Utilities.connectionString;
            using (var conn = new SqlConnection(connString))
            {
                var command = conn.CreateCommand();
                command.CommandText = "DELETE FROM HoaDon WHERE MaKH = @MaKH; DELETE FROM KhachHang WHERE MaKH = @MaKH";
                command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                conn.Open();
                int numberOfRowsAffected = command.ExecuteNonQuery();

                if (numberOfRowsAffected == 1)
                {
                    if (dgvDSKH.SelectedRows.Count > 0)
                    {
                        dgvDSKH.Rows.RemoveAt(dgvDSKH.SelectedRows[0].Index);
                    }

                    txtMaKH.Clear();
                    txtHo.Clear();
                    txtTen.Clear();
                    txtDiaChi.Clear();
                    mtxtSDT.Clear();
                    txtCCCD.Clear();
                    txtNotes.Clear();

                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Khách đang thuê không thể xóa", "Thông báo");
                }
            }
        }
        public int ThemKhachHang(string hoKH, string tenKH,string gioitinh, string diaChi, string sdt, string cccd, string notes)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);
            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO KhachHang VALUES (@HoKH, @TenKH, @GioiTinh, @DiaChi, @SDT,@CCCD,@Notes)";

            // Thêm giá trị cho tham số
            command.Parameters.AddWithValue("HoKH", hoKH);
            command.Parameters.AddWithValue("TenKH", tenKH);
            command.Parameters.AddWithValue("GioiTinh", gioitinh);

            command.Parameters.AddWithValue("DiaChi", diaChi);
            command.Parameters.AddWithValue("SDT", sdt);
            command.Parameters.AddWithValue("CCCD", cccd);
            command.Parameters.AddWithValue("Notes", notes);

            conn.Open();

            var soDongAnhHuong = command.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();

            return soDongAnhHuong;
        }

        // Sửa khách hàng
        public int SuaKhachHang(string maKH, string hoKH, string tenKH, string gioitinh,string diaChi, string sdt, string cccd, string notes)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();
            command.CommandText = "UPDATE KhachHang SET HoKH = @HoKH, TenKH = @TenKH, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT,CCCD = @CCCD,Notes = @Notes " + "WHERE MaKH = @MaKH";
            // Thêm giá trị cho tham số
            command.Parameters.AddWithValue("MaKH", maKH);

            command.Parameters.AddWithValue("HoKH", hoKH);
            command.Parameters.AddWithValue("TenKH", tenKH);
            command.Parameters.AddWithValue("GioiTinh", gioitinh);

            command.Parameters.AddWithValue("DiaChi", diaChi);
            command.Parameters.AddWithValue("SDT", sdt);

            command.Parameters.AddWithValue("CCCD", cccd);
            command.Parameters.AddWithValue("Notes", notes);

            conn.Open();

            var soDongAnhHuong = command.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();

            return soDongAnhHuong;
        }

        private void btnCapNhatThem_Click(object sender, EventArgs e)
        {
            var maKH = txtMaKH.Text;
            var hoKH = txtHo.Text;
            var tenKH = txtTen.Text;
            var gioitinh = cbbGioiTinh.Text;
            var diaChi = txtDiaChi.Text;
            var sdt = mtxtSDT.Text;
            var cccd = txtCCCD.Text;
            var notes = txtNotes.Text;
            var soDongAnhHuong = -1;

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập họ tên và số điện thoại của khách hàng");
                return;
            }
            if (string.IsNullOrEmpty(maKH))
            {
                soDongAnhHuong = ThemKhachHang(hoKH, tenKH, gioitinh,diaChi, sdt, cccd, notes);
            }
            else
                soDongAnhHuong = SuaKhachHang(maKH, hoKH, tenKH,gioitinh, diaChi, sdt, cccd, notes);
            if (soDongAnhHuong > 0)
            {
                MessageBox.Show("Thêm/Sửa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm/Sửa không thành công", "Thông báo");
            }
            LayDSKhachHang();
            
        }
        public void TimKiemKhachHang(string keyword, string type)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu từ khóa rỗng, lấy toàn bộ danh sách khách hàng
                command.CommandText = "SELECT * FROM KhachHang";
            }
            else
            {
                // Tìm kiếm theo Tên hoặc Số điện thoại
                if (type == "Ten")
                {
                    command.CommandText = "SELECT * FROM KhachHang WHERE TenKH LIKE @Keyword";
                }
                else if (type == "SDT")
                {
                    command.CommandText = "SELECT * FROM KhachHang WHERE SDT LIKE @Keyword";
                }
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
            }

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            // Hiển thị kết quả lên DataGridView
            dgvDSKH.DataSource = table;

            // Cập nhật lại ràng buộc dữ liệu

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim();
            if (rbTheoTen.Checked)
            {
                TimKiemKhachHang(keyword, "Ten");
            }
            else if (rbTheoSDT.Checked)
            {
                TimKiemKhachHang(keyword, "SDT");
            }
            else
            {
                LayDSKhachHang();
            }
        }
    }
}