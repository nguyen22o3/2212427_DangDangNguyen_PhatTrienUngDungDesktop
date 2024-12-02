using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApss
{
    public partial class frmBangDia : Form
    {
        private DataTable dtBangDia;
        public frmBangDia()
        {
            InitializeComponent();
            LayDS();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new Thông_tin_nhân_viên();
            from.ShowDialog();
        }

        private void quảnLíKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new Chi_tiết_hoá_đơn();
            from.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new Màn_Hình_Đăng_Nhập();
            from.ShowDialog();
            this.Close();
        }
        public void LayDS()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT MaDia, TenDia, SoLuong, Gia, TinhTrang FROM Dia";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            dgvTT.DataSource = table;     
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LayDS();
        }

        private void dgvTT_Click(object sender, EventArgs e)
        {
            if (dgvTT.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                var selectedRow = dgvTT.SelectedRows[0];

                string tenSanPham = selectedRow.Cells["TenDia"].Value.ToString();
                decimal giaSanPham = Convert.ToDecimal(selectedRow.Cells["GiaBan"].Value);

                // Kiểm tra sản phẩm đã tồn tại trong hóa đơn
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (row.Cells["TenSanPham"].Value.ToString() == tenSanPham)
                    {
                        // Cập nhật số lượng và tổng tiền
                        int soLuongHienTai = Convert.ToInt32(row.Cells["so_Luong"].Value);
                        row.Cells["so_Luong"].Value = soLuongHienTai + 1;
                        decimal tong = giaSanPham * (soLuongHienTai + 1);
                        lbTong.Text = tong.ToString();
                        return; // Kết thúc vì đã cập nhật
                    }
                }

                // Nếu sản phẩm chưa tồn tại, thêm vào hóa đơn
                int soLuong = 1;
                decimal tongTien = giaSanPham * soLuong;
                lbTong.Text = tongTien.ToString();
                dgvHoaDon.Rows.Add(tenSanPham, giaSanPham, soLuong, tongTien);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void TimKiem(string keyword, string type)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu từ khóa rỗng, lấy danh sách đĩa
                command.CommandText = "SELECT MaDia, TenDia, SoLuong, TinhTrang FROM Dia";
            }
            else
            {
                // Tìm kiếm theo Tên
                if (type == "Ten")
                {
                    command.CommandText = "SELECT * FROM Dia WHERE TenDia LIKE @Keyword";
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
            dgvTT.DataSource = table;

        }

        private void btnSeard_Click(object sender, EventArgs e)
        {
            var keyword = txtSeard.Text.Trim();
            TimKiem(keyword, "Ten");
        }
        private void LoadTheLoai()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT MaLoai, TheLoai FROM TheLoai";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            DataRow row = table.NewRow();
            row["MaLoai"] = DBNull.Value;
            row["TheLoai"] = "Tất cả";
            table.Rows.InsertAt(row, 0);

            cbbTL.DataSource = table;
            cbbTL.DisplayMember = "TheLoai";
            cbbTL.ValueMember = "MaLoai";
        }

        private void cbbTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTL.SelectedIndex == -1) return;
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();

            if (cbbTL.SelectedValue == DBNull.Value)
            {
                command.CommandText = "SELECT MaDia, TenDia, SoLuong, TinhTrang FROM Dia";
            }
            else
            {
                command.CommandText = "SELECT * FROM Dia WHERE MaLoai = @theloaiId";

                command.Parameters.Add("@theloaiId", SqlDbType.Int);

                if (cbbTL.SelectedValue is DataRowView)
                {
                    DataRowView rowView = cbbTL.SelectedValue as DataRowView;
                    command.Parameters["@theloaiId"].Value = rowView["MaLoai"];
                }
                else
                {
                    command.Parameters["@theloaiId"].Value = cbbTL.SelectedValue;
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dtBangDia = new DataTable();

            conn.Open();

            adapter.Fill(dtBangDia);

            conn.Close();
            conn.Dispose();
            dgvTT.DataSource = dtBangDia;

        }

        private void frmBangDia_Load(object sender, EventArgs e)
        {
            this.LoadTheLoai();
            this.LayDS();
            groupBox2.Hide();
        }

        public void TimKiemKhachHang(string keyword, string type)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();

           // Tìm kiếm theo Số điện thoại
           if (type == "SDT")
           {
                command.CommandText = "SELECT * FROM KhachHang WHERE SDT LIKE @Keyword";
           }
            command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            // Hiển thị kết quả
            if (table.Rows.Count > 0)
            {
                var row = table.Rows[0];
                txtName.Text = row["TenKH"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
            }
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            var keyword = txtSDT.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimKiemKhachHang(keyword, "SDT");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();

            command.CommandText = "INSERT INTO KhachHang(TenKH, DiaChi, SDT)" + "VALUES (N'" + txtName.Text + "', N'" + txtDiaChi.Text + "', " + txtSDT.Text + ")";
            conn.Open();

            int numOfRow = command.ExecuteNonQuery();

            conn.Close();

            if (numOfRow == 1)
            {
                MessageBox.Show("Thêm khách hàng thành công");
                txtName.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtSDT.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Đã có xảy ra. Vui lòng thử lại");
            }
        }

        private void cbThue_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Show();
            dtpNgayThue.Value = DateTime.Now;
        }

        private void frmBangDia_FormClosed(object sender, FormClosedEventArgs e)
        {
/*            Application.Exit();
*/        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu hóa đơn có ít nhất một sản phẩm
            if (dgvHoaDon.Rows.Count > 0)
            {
                try
                {
                    var connString = Utilities.connectionString;
                    using (var conn = new SqlConnection(connString))
                    {
                        conn.Open();

                        // Bắt đầu một transaction
                        using (var transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Insert hóa đơn
                                var insertHoaDonCmd = new SqlCommand("INSERT INTO HoaDon (MaKH, MaNV, NgayThue, HanThue, Tong) VALUES (@MaKH, @MaNV, @NgayThue, @HanThue, @Tong); SELECT SCOPE_IDENTITY();", conn, transaction);
                                insertHoaDonCmd.Parameters.AddWithValue("@MaKH", SqlDbType.Int);
                                insertHoaDonCmd.Parameters.AddWithValue("@MaNV", SqlDbType.Int);
                                insertHoaDonCmd.Parameters.AddWithValue("@NgayThue", DateTime.Now);
                                insertHoaDonCmd.Parameters.AddWithValue("@HanThue", dtkHanThue.Value);
                                insertHoaDonCmd.Parameters.AddWithValue("@TongTien", Convert.ToDecimal(lbTong.Text));

                                // Lấy ID của hóa đơn mới vừa chèn
                                var hoaDonID = Convert.ToInt32(insertHoaDonCmd.ExecuteScalar());

                                // Insert các chi tiết hóa đơn
                                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                                {
                                    if (row.IsNewRow) continue;  // Bỏ qua dòng mới (chưa có dữ liệu)

                                    var tenSanPham = row.Cells["TenSanPham"].Value.ToString();
                                    var gia = Convert.ToDecimal(row.Cells["Gia"].Value);
                                    var soLuong = Convert.ToInt32(row.Cells["so_Luong"].Value);

                                    var insertChiTietCmd = new SqlCommand("INSERT INTO ChiTietHoaDon (ID, MaHD, MaDia, Gia, Soluong, GiamGia, PhatSinh, ThanhTien) VALUES (@HoaDonID, @MaHD, @TenSanPham, @Gia, @SoLuong, @GiamGia, @PhatSinh, @ThanhTien);", conn, transaction);
                                    insertChiTietCmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                                    insertChiTietCmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                                    insertChiTietCmd.Parameters.AddWithValue("@Gia", gia);
                                    insertChiTietCmd.Parameters.AddWithValue("@SoLuong", soLuong);
                                    insertChiTietCmd.Parameters.AddWithValue("@GiamGia", Convert.ToDecimal(lbGiamGia.Text));
                                    insertChiTietCmd.Parameters.AddWithValue("@PhatSinh", Convert.ToDecimal(lbPhatSinh.Text));
                                    insertChiTietCmd.Parameters.AddWithValue("@ThanhTien", Convert.ToDecimal(lbTong.Text));

                                    insertChiTietCmd.ExecuteNonQuery();
                                }

                                // Commit transaction nếu không có lỗi
                                transaction.Commit();
                                MessageBox.Show("Hóa đơn đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                // Nếu có lỗi, rollback transaction
                                transaction.Rollback();
                                MessageBox.Show($"Có lỗi xảy ra khi lưu hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
