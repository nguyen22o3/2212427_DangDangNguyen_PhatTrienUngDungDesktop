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

namespace Lab7_Advanced_Command
{
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }

        private void InitValues()
        {
            string connectionString = "server= PC807; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            //Mở kết nối
            conn.Open();

            //Lấy dữ liệu từ csdl đưa vào DataTable
            adapter.Fill(ds, "Category");

            //Hiển thị nhóm món ăn
            cbbCategoryName.DataSource = ds.Tables["Category"];
            cbbCategoryName.DisplayMember = "Name";
            cbbCategoryName.ValueMember = "ID";

            conn.Close();
            conn.Dispose();
        }
        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCategoryName.ResetText();
            nudPrice.ResetText();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server= PC807; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

                //Thêm tham số vào đối tượng command
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCategoryName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                //Thông báo kết quả
                if (numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Thêm món mới thành công. Food ID = " + foodID, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm món mới thất bại");
                }
                conn.Close();
                conn.Dispose();
            }
            //Bắt lỗi SQL và các lỗi khác
            catch (SqlException excp)
            {
                MessageBox.Show(excp.Message, "SQL Error");
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Error");
            }
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server= PC807; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

                //Thêm tham số vào đối tượng command
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                //Truyền giá trị vào thủ tục qua tham số
                cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCategoryName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                //Thông báo kết quả
                if (numRowAffected > 0)
                {

                    MessageBox.Show("Cập nhật món ăn thành công", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại");
                }
                conn.Close();
                conn.Dispose();
            }
            //Bắt lỗi SQL và các lỗi khác
            catch (SqlException excp)
            {
                MessageBox.Show(excp.Message, "SQL Error");
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Error");
            }
        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();

                cbbCategoryName.SelectedIndex = -1;

                //Chọn món ăn tương ứng
                for (int index = 0; index < cbbCategoryName.Items.Count; index++)
                {
                    DataRowView cat = cbbCategoryName.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCategoryName.SelectedIndex = index;
                        break;
                    }
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Error");
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
