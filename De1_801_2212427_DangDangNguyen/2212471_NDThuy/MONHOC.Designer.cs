namespace _2212471_NDThuy
{
    partial class MONHOC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.cbbCTDT = new System.Windows.Forms.ComboBox();
            this.nudSoTC = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chương trình ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tín chỉ";
            // 
            // txtMMH
            // 
            this.txtMMH.Location = new System.Drawing.Point(126, 31);
            this.txtMMH.Name = "txtMMH";
            this.txtMMH.Size = new System.Drawing.Size(134, 20);
            this.txtMMH.TabIndex = 4;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(126, 65);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(134, 20);
            this.txtTenMH.TabIndex = 5;
            // 
            // cbbCTDT
            // 
            this.cbbCTDT.FormattingEnabled = true;
            this.cbbCTDT.Location = new System.Drawing.Point(126, 97);
            this.cbbCTDT.Name = "cbbCTDT";
            this.cbbCTDT.Size = new System.Drawing.Size(134, 21);
            this.cbbCTDT.TabIndex = 6;
            // 
            // nudSoTC
            // 
            this.nudSoTC.Location = new System.Drawing.Point(126, 127);
            this.nudSoTC.Name = "nudSoTC";
            this.nudSoTC.Size = new System.Drawing.Size(134, 20);
            this.nudSoTC.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(126, 166);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // MONHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 222);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.nudSoTC);
            this.Controls.Add(this.cbbCTDT);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MONHOC";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.MONHOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.ComboBox cbbCTDT;
        private System.Windows.Forms.NumericUpDown nudSoTC;
        private System.Windows.Forms.Button btnLuu;
    }
}

