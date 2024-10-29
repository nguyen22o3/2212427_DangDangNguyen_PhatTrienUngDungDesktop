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

namespace Lab6_Basic_Command
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }
        public void LoadFood(int categoryID)
        {
            // Tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = "server = PC813; database = RestaurantManagement; Integrated Security = true;";

            // Tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

            //Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            //Gán tên nhóm sản phẩm cho tiêu đề
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

            //Tạo đối tượng DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            //Tạo data table để chứa dữ liệu
            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            //Hiển thị danh sách món ăn lên Form
            dgvFood.DataSource = dt;

            //Đóng kết nối và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
    }
}
