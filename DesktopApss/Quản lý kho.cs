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
    public partial class Quản_ly_kho : Form
    {
        public Quản_ly_kho()
        {
            InitializeComponent();
        }
        private void LayDSLoaiDia(SqlDataReader reader)
        {
            listView1.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["MaDia"].ToString());

                listView1.Items.Add(item);

                item.SubItems.Add(reader["TenDia"].ToString());
                item.SubItems.Add(reader["MaLoai"].ToString());
                item.SubItems.Add(reader["Gia"].ToString());
                item.SubItems.Add(reader["SoLuong"].ToString());
                item.SubItems.Add(reader["TinhTrang"].ToString());
                item.SubItems.Add(reader["Notes"].ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            SqlCommand sqlCommand = conn.CreateCommand();

            sqlCommand.CommandText = "UPDATE Dia SET Name N'" + txtNameDia.Text +
                "', MaLoai = " + cbTheLoai.Text +
                " GiaBan = " + txtGiaBan.Text +
                " SoLuong = " + txtSoLuong.Text +
                " [TinhTrang] = " + txtTinhTrang.Text;

            sqlCommand.ExecuteNonQuery();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            conn.Close();

            if (numOfRowsEffected == 1)
            {
                ListViewItem item = listView1.SelectedItems[0];

                item.SubItems[1].Text = txtNameDia.Text;
                item.SubItems[2].Text = cbTheLoai.Text;
                item.SubItems[3].Text = txtGiaBan.Text;
                item.SubItems[4].Text = txtSoLuong.Text;
                item.SubItems[5].Text = txtTinhTrang.Text;

                txtNameDia.Text = "";
                cbTheLoai.Text = "";
                txtGiaBan.Text = "";
                txtSoLuong.Text = "";
                txtTinhTrang.Text = "";

                btnUpdate.Enabled = false;

                MessageBox.Show("Cập nhật đĩa thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại sau");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            SqlCommand sqlCommand = conn.CreateCommand();

            sqlCommand.CommandText = "INSERT INTO Dia (MaDia, Maloai, GiaBan, SoLuong, [TinhTrang])" +
                          "VALUES ('" + txtNameDia.Text + "', '" + cbTheLoai.Text + "', " +
                                  txtGiaBan.Text + ", " + txtSoLuong.Text + ", '" + txtTinhTrang + "')";

            conn.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            conn.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm đĩa thành công");

                btnLoad.PerformClick();

                txtNameDia.Text = "";
                cbTheLoai.Text = "";
                txtGiaBan.Text = "";
                txtSoLuong.Text = "";
                txtTinhTrang.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại sau");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            SqlCommand sqlCommand = conn.CreateCommand();
            string query = "SELECT MaDia, TenDia, MaLoai, Gia, SoLuong, TinhTrang, Notes FROM Dia";

            sqlCommand.CommandText = query;

            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            this.LayDSLoaiDia(sqlDataReader);

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            SqlCommand sqlCommand = conn.CreateCommand();
            string query = "SELECT MaLoai, TheLoai FROM TheLoai";

            sqlCommand.CommandText = query;

            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            this.TheLoai(sqlDataReader);

            conn.Close();
        }
        private void TheLoai(SqlDataReader reader)
        {
            listView2.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["MaLoai"].ToString());

                listView2.Items.Add(item);

                item.SubItems.Add(reader["TheLoai"].ToString());
            }
        }
    }
}
