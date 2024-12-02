using DesktopApss.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApss
{
    public partial class Màn_Hình_Đăng_Nhập : Form
    {
        public Màn_Hình_Đăng_Nhập()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = txtTK.Text;
            string matkhau = txtMK.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "Select * from Account where AccountName = '"+tentk+"' and Password = '"+matkhau+"'";
                if (modify.Accounts(query).Count() > 0)
                {
                    if(tentk == "ha")
                    {
                        FrmAD ad = new FrmAD();
                        ad.ShowDialog();
                        this.Close();
                    } 
                    else
                    {
                        frmBangDia f = new frmBangDia();
                        f.ShowDialog();
                        this.Close();
                    }    
                }
                else
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as frmBangDia).Close();
            this.Show();
        }

        private void btnExit_CLick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Màn_Hình_Đăng_Nhập_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
