namespace _2212471_NDThuy
{
    partial class QuanLyMonHoc
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.rd2015 = new System.Windows.Forms.RadioButton();
            this.rd2017 = new System.Windows.Forms.RadioButton();
            this.rd2020 = new System.Windows.Forms.RadioButton();
            this.rdTimKiem2 = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTimKiem1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd2020);
            this.groupBox1.Controls.Add(this.rd2017);
            this.groupBox1.Controls.Add(this.rd2015);
            this.groupBox1.Controls.Add(this.rdTatCa);
            this.groupBox1.Location = new System.Drawing.Point(121, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chương trình đào tạo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTimKiem1);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.rdTimKiem2);
            this.groupBox2.Location = new System.Drawing.Point(121, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // rdTatCa
            // 
            this.rdTatCa.AutoSize = true;
            this.rdTatCa.Checked = true;
            this.rdTatCa.Location = new System.Drawing.Point(17, 19);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(56, 17);
            this.rdTatCa.TabIndex = 0;
            this.rdTatCa.TabStop = true;
            this.rdTatCa.Text = "Tất cả";
            this.rdTatCa.UseVisualStyleBackColor = true;
            this.rdTatCa.CheckedChanged += new System.EventHandler(this.rdTatCa_CheckedChanged);
            // 
            // rd2015
            // 
            this.rd2015.AutoSize = true;
            this.rd2015.Location = new System.Drawing.Point(128, 19);
            this.rd2015.Name = "rd2015";
            this.rd2015.Size = new System.Drawing.Size(49, 17);
            this.rd2015.TabIndex = 1;
            this.rd2015.Text = "2015";
            this.rd2015.UseVisualStyleBackColor = true;
            this.rd2015.CheckedChanged += new System.EventHandler(this.rd2015_CheckedChanged);
            // 
            // rd2017
            // 
            this.rd2017.AutoSize = true;
            this.rd2017.Location = new System.Drawing.Point(231, 19);
            this.rd2017.Name = "rd2017";
            this.rd2017.Size = new System.Drawing.Size(49, 17);
            this.rd2017.TabIndex = 2;
            this.rd2017.Text = "2017";
            this.rd2017.UseVisualStyleBackColor = true;
            this.rd2017.CheckedChanged += new System.EventHandler(this.rd2017_CheckedChanged);
            // 
            // rd2020
            // 
            this.rd2020.AutoSize = true;
            this.rd2020.Location = new System.Drawing.Point(322, 19);
            this.rd2020.Name = "rd2020";
            this.rd2020.Size = new System.Drawing.Size(49, 17);
            this.rd2020.TabIndex = 3;
            this.rd2020.Text = "2020";
            this.rd2020.UseVisualStyleBackColor = true;
            this.rd2020.CheckedChanged += new System.EventHandler(this.rd2020_CheckedChanged);
            // 
            // rdTimKiem2
            // 
            this.rdTimKiem2.AutoSize = true;
            this.rdTimKiem2.Location = new System.Drawing.Point(141, 29);
            this.rdTimKiem2.Name = "rdTimKiem2";
            this.rdTimKiem2.Size = new System.Drawing.Size(81, 17);
            this.rdTimKiem2.TabIndex = 2;
            this.rdTimKiem2.TabStop = true;
            this.rdTimKiem2.Text = "Theo số TC";
            this.rdTimKiem2.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(253, 29);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(175, 20);
            this.txtTimKiem.TabIndex = 4;
            // 
            // rdTimKiem1
            // 
            this.rdTimKiem1.AutoSize = true;
            this.rdTimKiem1.Location = new System.Drawing.Point(17, 30);
            this.rdTimKiem1.Name = "rdTimKiem1";
            this.rdTimKiem1.Size = new System.Drawing.Size(107, 17);
            this.rdTimKiem1.TabIndex = 5;
            this.rdTimKiem1.TabStop = true;
            this.rdTimKiem1.Text = "Theo mã/tên MH";
            this.rdTimKiem1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.dgvMonHoc);
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách môn học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMonHoc.Location = new System.Drawing.Point(6, 40);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(628, 210);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellDoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(592, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(42, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "+";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.xemDanhToolStripMenuItem,
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(302, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // xemDanhToolStripMenuItem
            // 
            this.xemDanhToolStripMenuItem.Name = "xemDanhToolStripMenuItem";
            this.xemDanhToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.xemDanhToolStripMenuItem.Text = "Xem danh sách sinh viên đăng ký môn học";
            // 
            // tổngSốLượngSVĐăngKýMHToolStripMenuItem
            // 
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem.Name = "tổngSốLượngSVĐăngKýMHToolStripMenuItem";
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem.Text = "Tổng số lượng SV đăng ký MH";
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem.Click += new System.EventHandler(this.tổngSốLượngSVĐăngKýMHToolStripMenuItem_Click);
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd2020;
        private System.Windows.Forms.RadioButton rd2017;
        private System.Windows.Forms.RadioButton rd2015;
        private System.Windows.Forms.RadioButton rdTatCa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTimKiem1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTimKiem2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngSốLượngSVĐăngKýMHToolStripMenuItem;
    }
}