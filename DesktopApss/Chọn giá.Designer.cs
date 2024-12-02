namespace DesktopApss
{
    partial class Chọn
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
            this.txtChuThich = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.rdGiaBan = new System.Windows.Forms.RadioButton();
            this.rdGiaThue = new System.Windows.Forms.RadioButton();
            this.rdGiaNV = new System.Windows.Forms.RadioButton();
            this.rdFree = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtChuThich
            // 
            this.txtChuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuThich.Location = new System.Drawing.Point(103, 147);
            this.txtChuThich.Multiline = true;
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Size = new System.Drawing.Size(423, 108);
            this.txtChuThich.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chú thích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(103, 12);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(423, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(331, 280);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 30);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSize = true;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(180, 280);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(95, 30);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // rdGiaBan
            // 
            this.rdGiaBan.AutoSize = true;
            this.rdGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGiaBan.Location = new System.Drawing.Point(21, 81);
            this.rdGiaBan.Name = "rdGiaBan";
            this.rdGiaBan.Size = new System.Drawing.Size(80, 20);
            this.rdGiaBan.TabIndex = 3;
            this.rdGiaBan.TabStop = true;
            this.rdGiaBan.Text = "Giá Bán";
            this.rdGiaBan.UseVisualStyleBackColor = true;
            // 
            // rdGiaThue
            // 
            this.rdGiaThue.AutoSize = true;
            this.rdGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGiaThue.Location = new System.Drawing.Point(169, 81);
            this.rdGiaThue.Name = "rdGiaThue";
            this.rdGiaThue.Size = new System.Drawing.Size(88, 20);
            this.rdGiaThue.TabIndex = 3;
            this.rdGiaThue.TabStop = true;
            this.rdGiaThue.Text = "Giá Thuê";
            this.rdGiaThue.UseVisualStyleBackColor = true;
            // 
            // rdGiaNV
            // 
            this.rdGiaNV.AutoSize = true;
            this.rdGiaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGiaNV.Location = new System.Drawing.Point(327, 81);
            this.rdGiaNV.Name = "rdGiaNV";
            this.rdGiaNV.Size = new System.Drawing.Size(74, 20);
            this.rdGiaNV.TabIndex = 3;
            this.rdGiaNV.TabStop = true;
            this.rdGiaNV.Text = "Giá NV";
            this.rdGiaNV.UseVisualStyleBackColor = true;
            // 
            // rdFree
            // 
            this.rdFree.AutoSize = true;
            this.rdFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFree.Location = new System.Drawing.Point(469, 81);
            this.rdFree.Name = "rdFree";
            this.rdFree.Size = new System.Drawing.Size(57, 20);
            this.rdFree.TabIndex = 3;
            this.rdFree.TabStop = true;
            this.rdFree.Text = "Free";
            this.rdFree.UseVisualStyleBackColor = true;
            // 
            // Chọn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(553, 322);
            this.ControlBox = false;
            this.Controls.Add(this.rdFree);
            this.Controls.Add(this.rdGiaNV);
            this.Controls.Add(this.rdGiaThue);
            this.Controls.Add(this.rdGiaBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtChuThich);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Name = "Chọn";
            this.Load += new System.EventHandler(this.Chọn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChuThich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.RadioButton rdGiaBan;
        private System.Windows.Forms.RadioButton rdGiaThue;
        private System.Windows.Forms.RadioButton rdGiaNV;
        private System.Windows.Forms.RadioButton rdFree;
    }
}