using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212427_DangDangNguyen_Lab02
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmVD1_Click(object sender, EventArgs e)
        {
            var form=new frmViDu1();
            form.ShowDialog();
        }

        private void tsmVD2_Click(object sender, EventArgs e)
        {
            var form = new frmViDu2();
            form.ShowDialog();
        }
    }
}
