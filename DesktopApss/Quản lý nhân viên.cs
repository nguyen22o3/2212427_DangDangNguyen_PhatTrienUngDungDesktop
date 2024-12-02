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
    public partial class Quản_lý_nhân_viên : Form
    {
        public Quản_lý_nhân_viên()
        {
            InitializeComponent();
        }
        private void LoadNhanVien()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaNV, HoNV, TenNV, GioiTinh, ChucVu, NgaySinh, NgayVaoLam, SDT, CCCD, DiaChi, Luong, Notes FROM NhanVien";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            dgvNhanVien.DataSource = dt;
        }

        private void Quản_lý_nhân_viên_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            cbbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];

                // Gán giá trị từ DataGridView vào các điều khiển
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtHo.Text = row.Cells["HoNV"].Value?.ToString();
                txtTen.Text = row.Cells["TenNV"].Value?.ToString();
                cbbGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                DateTime? ngaySinh = row.Cells["NgaySinh"].Value as DateTime?;
                DateTime? ngayVaoLam = row.Cells["NgayVaoLam"].Value as DateTime?;

                // Kiểm tra và gán giá trị cho DateTimePicker nếu có dữ liệu
                if (ngaySinh.HasValue)
                    dtpNgaySinh.Value = ngaySinh.Value;
                else
                    dtpNgaySinh.Value = DateTime.Now; // Hoặc có thể gán giá trị mặc định nếu dữ liệu null

                if (ngayVaoLam.HasValue)
                    dtpNgayVaoLam.Value = ngayVaoLam.Value;
                else
                    dtpNgayVaoLam.Value = DateTime.Now; // Hoặc giá trị mặc định
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtLuong.Text = row.Cells["Luong"].Value?.ToString();
                txtNotes.Text = row.Cells["Notes"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var connString = Utilities.connectionString;
                var conn = new SqlConnection(connString);

                // Tạo câu lệnh SQL để thêm nhân viên mới
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertNhanVien @id OUTPUT, @HoNV, @TenNV, @GioiTinh, @ChucVu, @NgaySinh, @NgayVaoLam, @SDT, @CCCD, @DiaChi, @Luong, @Notes";

                // Thêm tham số cho các trường dữ liệu
                cmd.Parameters.Add("@id", SqlDbType.Int); // Mã nhân viên (ID) sẽ được tự động sinh
                cmd.Parameters.Add("@HoNV", SqlDbType.NVarChar, 1000).Value = txtHo.Text;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 1000).Value = txtTen.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NChar, 10).Value = cbbGioiTinh.SelectedItem.ToString();
                cmd.Parameters.Add("@ChucVu", SqlDbType.NChar, 10).Value = txtChucVu.Text;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = dtpNgaySinh.Value;
                cmd.Parameters.Add("@NgayVaoLam", SqlDbType.DateTime).Value = dtpNgayVaoLam.Value;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 15).Value = txtSDT.Text;
                cmd.Parameters.Add("@CCCD", SqlDbType.NVarChar, 12).Value = txtCCCD.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = Convert.ToInt32(txtLuong.Text);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = txtNotes.Text;

                // Thiết lập tham số OUTPUT cho Mã nhân viên (ID) tự động
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                // Mở kết nối
                conn.Open();

                // Thực thi câu lệnh SQL và nhận số dòng bị ảnh hưởng
                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    // Lấy ID của nhân viên vừa thêm
                    string employeeID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Thêm nhân viên thành công. Mã nhân viên = " + employeeID, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset lại các ô nhập liệu sau khi thêm thành công
                    ResetText();

                    // Cập nhật lại danh sách nhân viên nếu cần thiết (ví dụ, gọi lại phương thức LoadNhanVien)
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Đóng kết nối và giải phóng tài nguyên
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void ResetText()
        //{
        //    // Reset lại các textbox và các điều khiển nhập liệu sau khi thêm nhân viên thành công
        //    txtMaNV.Clear();
        //    txtHo.Clear();
        //    txtTen.Clear();
        //    cbbGioiTinh.SelectedIndex = -1;
        //    txtChucVu.Clear();
        //    dtpNgaySinh.Value = DateTime.Now;
        //    dtpNgayVaoLam.Value = DateTime.Now;
        //    txtSDT.Clear();
        //    txtCCCD.Clear();
        //    txtDiaChi.Clear();
        //    txtLuong.Clear();
        //    txtNotes.Clear();
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var connString = Utilities.connectionString;
                var conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateNhanVien @id, @hoNV, @tenNV, @gioiTinh, @chucVu, @ngaySinh, @ngayVaoLam, @sdt, @cccd, @diaChi, @luong, @notes";

                // Thêm các tham số vào câu lệnh SQL
                cmd.Parameters.Add("@id", SqlDbType.Int); // Mã nhân viên (ID) sẽ được tự động sinh
                cmd.Parameters.Add("@HoNV", SqlDbType.NVarChar, 1000).Value = txtHo.Text;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 1000).Value = txtTen.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NChar, 10).Value = cbbGioiTinh.SelectedItem.ToString();
                cmd.Parameters.Add("@ChucVu", SqlDbType.NChar, 10).Value = txtChucVu.Text;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = dtpNgaySinh.Value;
                cmd.Parameters.Add("@NgayVaoLam", SqlDbType.DateTime).Value = dtpNgayVaoLam.Value;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 15).Value = txtSDT.Text;
                cmd.Parameters.Add("@CCCD", SqlDbType.NVarChar, 12).Value = txtCCCD.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = Convert.ToInt32(txtLuong.Text);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = txtNotes.Text;

                // Gán giá trị cho các tham số
                cmd.Parameters["@id"].Value = int.Parse(txtMaNV.Text); // MaNV cần cập nhật
                cmd.Parameters["@HoNV"].Value = txtHo.Text;
                cmd.Parameters["@TenNV"].Value = txtTen.Text;
                cmd.Parameters["@GioiTinh"].Value = cbbGioiTinh.SelectedItem.ToString();
                cmd.Parameters["@ChucVu"].Value = txtChucVu.Text;
                cmd.Parameters["@NgaySinh"].Value = dtpNgaySinh.Value;
                cmd.Parameters["@NgayVaoLam"].Value = dtpNgayVaoLam.Value;
                cmd.Parameters["@Sdt"].Value = txtSDT.Text;
                cmd.Parameters["@Cccd"].Value = txtCCCD.Text;
                cmd.Parameters["@DiaChi"].Value = txtDiaChi.Text;
                cmd.Parameters["@Luong"].Value = int.Parse(txtLuong.Text);
                cmd.Parameters["@Notes"].Value = txtNotes.Text;

                // Mở kết nối và thực thi câu lệnh
                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    MessageBox.Show("Sửa nhân viên thành công", "Message");
                    ResetText();  // Gọi hàm ResetText để làm sạch các ô nhập liệu
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Updating employee failed");
                }

                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn nhân viên để xóa chưa
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    var connString = Utilities.connectionString;
                    var conn = new SqlConnection(connString);

                    // Tạo câu lệnh SQL để xóa nhân viên theo Mã nhân viên (ID)
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE DeleteNhanVien @id";  // Giả sử thủ tục xóa có tên "DeleteNhanVien"

                    // Thêm tham số ID cho câu lệnh SQL
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(txtMaNV.Text); // Mã nhân viên cần xóa

                    // Mở kết nối và thực thi câu lệnh
                    conn.Open();

                    int numRowAffected = cmd.ExecuteNonQuery();

                    if (numRowAffected > 0)
                    {
                        MessageBox.Show("Nhân viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ResetText();  // Gọi hàm ResetText để làm sạch các ô nhập liệu
                        LoadNhanVien();    // Tải lại danh sách nhân viên
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên. Vui lòng kiểm tra lại Mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Đóng kết nối
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
