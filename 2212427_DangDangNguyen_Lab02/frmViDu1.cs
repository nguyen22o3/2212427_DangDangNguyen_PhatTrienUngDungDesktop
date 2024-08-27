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
    public partial class frmViDu1 : Form
    {
        public frmViDu1()
        {
            InitializeComponent();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }
        private void ReSet()
        {
            this.cboMaHocVien.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rbNam.Checked = true;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
            
                s += int.Parse(lblTienHocTHA.Text.Split('.')[0]);
            
            if (chkTinHocB.Checked)
            
                s += int.Parse(lblTienHocTHB.Text.Split('.')[0]);
            
            if (chkTiengAnhA.Checked)
            
                s += int.Parse(lblTienHocTAA.Text.Split('.')[0]);
            
            if (chkTiengAnhB.Checked)
            
                s += int.Parse(lblTienHocTAB.Text.Split('.')[0]);
            
            this.txtTongTien.Text = s + ".000 đồng";
        }

        private void frmTrungTam_Load(object sender, EventArgs e)
        {

        }

        private void frmTrungTam_Load_1(object sender, EventArgs e)
        {

        }
    }
}
