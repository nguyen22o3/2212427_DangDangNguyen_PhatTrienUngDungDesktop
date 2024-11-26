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

namespace _2212471_NDThuy
{
    public partial class MONHOC : Form
    {
        private string MaMH;

        public MONHOC()
        {
            InitializeComponent();
        }
        public MONHOC (string MaMH)
        {
            InitializeComponent();
            this.MaMH = MaMH;   
        }
        void LoadCTDT()
        {
            string connectstring = "Data Source=PC801;Initial Catalog=QLDKHP;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectstring);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select MACTDT , TENCTDT from ChuongTrinhDT";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbCTDT.DataSource = dt;
            cbbCTDT.DisplayMember = "TENCTDT";
            cbbCTDT.ValueMember = "MACTDT";
            
        }
        private void MONHOC_Load(object sender, EventArgs e)
        {
            LoadCTDT();
            if (MaMH != null)
                LoadInfo(MaMH);

        }
        private void LoadInfo(string maMH)
        {
            string connectstring = "Data Source=PC801;Initial Catalog=QLDKHP;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectstring);
            string query = "Select MAMH , TENMH , SOTC, MACTĐT from MONHOC WHERE MAMH = @MAMH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaMH", maMH);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                txtMMH.Text = reader["MaMH"].ToString();
                txtTenMH.Text = reader["TenMH"].ToString();
                nudSoTC.Value = Convert.ToInt32(reader["SoTC"]);
                cbbCTDT.SelectedValue = reader["MACTĐT"];
                
            }   
            reader.Close();
        }
        private string RandomKiTu(int length , Random random)
        {
            const string str = "ABCDEFGHIJK";
            char[] s = new char[length];
            for(int i = 0; i< length; i++)
            {
                s[i] = str[random.Next(str.Length)]; ;
            }    
            return new string(s);
            
        }
        private string RandomMaMH()
        {
            Random random = new Random();
            string part1 = RandomKiTu(2, random);
            string part2 = random.Next(1000, 10000).ToString();
            string maMH = part1 + part2;
            return maMH;
        }
        private void ThemMonHoc()
        {
            try
            {
                string connectstring = "Data Source=PC801;Initial Catalog=QLDKHP;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectstring);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText= "INSERT INTO MONHOC(MaMH,TeNMH,SoTC,MaCTĐT) VALUES (@MaMH,@TenMH,@SoTC,@MaCTĐT)";
  
                string maMH = RandomMaMH();
                cmd.Parameters.Add("@MAMH", SqlDbType.NChar, 10).Value = maMH;
                cmd.Parameters.Add("TENMH", SqlDbType.NVarChar, 50).Value=txtTenMH.Text;
                cmd.Parameters.Add("@SOTC", SqlDbType.Int).Value = (int)nudSoTC.Value;
                cmd.Parameters.Add("@MACTĐT", SqlDbType.Int).Value =(int)cbbCTDT.SelectedValue;

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Đã thêm môn học thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CapNhatMonHoc()
        {
            try
            {
                string connectstring = "Data Source=PC801;Initial Catalog=QLDKHP;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectstring);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText  = "UPDATE MONHOC SET TENMH = @TENMH , SOTC = @SOTC, MACTĐT = MACTĐT WHERE MAMH = @MAMH" ;
              

                cmd.Parameters.Add("@MAMH", SqlDbType.NChar, 10).Value = txtMMH.Text;
                cmd.Parameters.Add("TENMH", SqlDbType.NVarChar, 50).Value = txtTenMH.Text;
                cmd.Parameters.Add("@SOTC", SqlDbType.Int).Value = (int)nudSoTC.Value;
                cmd.Parameters.Add("@MACTĐT", SqlDbType.Int).Value = (int)cbbCTDT.SelectedValue;

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Đã cập nhật môn học thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMMH.Text == "")
                ThemMonHoc();
            else
                CapNhatMonHoc();
            this.Close();
        }
    }

    
}
