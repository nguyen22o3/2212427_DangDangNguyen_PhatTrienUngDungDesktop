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
    public partial class Chọn : Form
    {
        public Chọn()
        {
            InitializeComponent();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chọn_Load(object sender, EventArgs e)
        {
            LoadTT();
        }
        private void LoadTT()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT Gia FROM Dia";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            if (table.Rows.Count > 0)
            {
                var row = table.Rows[0];
                rdGiaThue.Text = row["Gia"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           
        }
    }
}
