namespace NhapThongTinSinhVien
{
    partial class TimSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbMSSV = new System.Windows.Forms.RadioButton();
            this.rbHoTen = new System.Windows.Forms.RadioButton();
            this.rbNgaySinh = new System.Windows.Forms.RadioButton();
            this.lblNhapThongTin = new System.Windows.Forms.Label();
            this.txtNhapThongTin = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbMSSV
            // 
            this.rbMSSV.AutoSize = true;
            this.rbMSSV.Location = new System.Drawing.Point(50, 55);
            this.rbMSSV.Name = "rbMSSV";
            this.rbMSSV.Size = new System.Drawing.Size(55, 17);
            this.rbMSSV.TabIndex = 0;
            this.rbMSSV.TabStop = true;
            this.rbMSSV.Text = "MSSV";
            this.rbMSSV.UseVisualStyleBackColor = true;
            this.rbMSSV.CheckedChanged += new System.EventHandler(this.rbMSSV_CheckedChanged);
            // 
            // rbHoTen
            // 
            this.rbHoTen.AutoSize = true;
            this.rbHoTen.Location = new System.Drawing.Point(256, 55);
            this.rbHoTen.Name = "rbHoTen";
            this.rbHoTen.Size = new System.Drawing.Size(57, 17);
            this.rbHoTen.TabIndex = 0;
            this.rbHoTen.TabStop = true;
            this.rbHoTen.Text = "Họ tên";
            this.rbHoTen.UseVisualStyleBackColor = true;
            this.rbHoTen.CheckedChanged += new System.EventHandler(this.rbHoTen_CheckedChanged);
            // 
            // rbNgaySinh
            // 
            this.rbNgaySinh.AutoSize = true;
            this.rbNgaySinh.Location = new System.Drawing.Point(461, 55);
            this.rbNgaySinh.Name = "rbNgaySinh";
            this.rbNgaySinh.Size = new System.Drawing.Size(72, 17);
            this.rbNgaySinh.TabIndex = 0;
            this.rbNgaySinh.TabStop = true;
            this.rbNgaySinh.Text = "Ngày sinh";
            this.rbNgaySinh.UseVisualStyleBackColor = true;
            this.rbNgaySinh.CheckedChanged += new System.EventHandler(this.rbNgaySinh_CheckedChanged);
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.AutoSize = true;
            this.lblNhapThongTin.Location = new System.Drawing.Point(47, 118);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(80, 13);
            this.lblNhapThongTin.TabIndex = 1;
            this.lblNhapThongTin.Text = "Nhập thông tin:";
            // 
            // txtNhapThongTin
            // 
            this.txtNhapThongTin.Location = new System.Drawing.Point(130, 111);
            this.txtNhapThongTin.Name = "txtNhapThongTin";
            this.txtNhapThongTin.Size = new System.Drawing.Size(264, 20);
            this.txtNhapThongTin.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(458, 108);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // TimSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 193);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNhapThongTin);
            this.Controls.Add(this.lblNhapThongTin);
            this.Controls.Add(this.rbNgaySinh);
            this.Controls.Add(this.rbHoTen);
            this.Controls.Add(this.rbMSSV);
            this.Name = "TimSinhVien";
            this.Text = "TimSinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMSSV;
        private System.Windows.Forms.RadioButton rbHoTen;
        private System.Windows.Forms.RadioButton rbNgaySinh;
        private System.Windows.Forms.Label lblNhapThongTin;
        private System.Windows.Forms.TextBox txtNhapThongTin;
        private System.Windows.Forms.Button btnTimKiem;
    }
}