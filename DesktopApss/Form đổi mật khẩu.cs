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
using static System.Net.Mime.MediaTypeNames;

namespace DesktopApss
{
    public partial class Form_đổi_mật_khẩu : Form
    {
        public Form_đổi_mật_khẩu()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            var matKhauCu = txtMKHienTai.Text.Trim();
            var matKhauMoi = txtNewMK.Text.Trim();
            var xacNhanMatKhauMoi = txtNhapLai.Text.Trim();

            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhauMoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != xacNhanMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DoiMatKhau(matKhauCu, matKhauMoi);

        }
        private void DoiMatKhau(string matKhauCu, string matKhauMoi)
        {
            var connString = Utilities.connectionString;

            using (var conn = new SqlConnection(connString))
            {
                var command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Account WHERE Password = @MatKhauCu";
                command.Parameters.AddWithValue("@MatKhauCu", matKhauCu);

                conn.Open();
                var result = (int)command.ExecuteScalar();

                if (result == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đổi mật khẩu
                command.CommandText = "UPDATE Account SET Password = @MatKhauMoi";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                var rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
