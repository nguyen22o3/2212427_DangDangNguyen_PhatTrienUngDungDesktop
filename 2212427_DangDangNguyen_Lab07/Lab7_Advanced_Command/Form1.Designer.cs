namespace Lab7_Advanced_Command
{
    partial class Form1
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
            this.lbChonNhomMonAn = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeperator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimTheoTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChonNhomMonAn
            // 
            this.lbChonNhomMonAn.AutoSize = true;
            this.lbChonNhomMonAn.Location = new System.Drawing.Point(0, 20);
            this.lbChonNhomMonAn.Name = "lbChonNhomMonAn";
            this.lbChonNhomMonAn.Size = new System.Drawing.Size(102, 13);
            this.lbChonNhomMonAn.TabIndex = 0;
            this.lbChonNhomMonAn.Text = "Chọn nhóm món ăn:";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(108, 12);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(211, 21);
            this.cbbCategory.TabIndex = 1;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFoodList.Location = new System.Drawing.Point(0, 39);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.Size = new System.Drawing.Size(638, 307);
            this.dgvFoodList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmSeperator,
            this.tsmAddFood,
            this.tsmUpdateFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 92);
            // 
            // tsmCalculateQuantity
            // 
            this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
            this.tsmCalculateQuantity.Size = new System.Drawing.Size(218, 22);
            this.tsmCalculateQuantity.Text = "Tính số lượng đã bán";
            this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
            // 
            // tsmSeperator
            // 
            this.tsmSeperator.Name = "tsmSeperator";
            this.tsmSeperator.Size = new System.Drawing.Size(218, 22);
            this.tsmSeperator.Text = "Seperator";
            // 
            // tsmAddFood
            // 
            this.tsmAddFood.Name = "tsmAddFood";
            this.tsmAddFood.Size = new System.Drawing.Size(218, 22);
            this.tsmAddFood.Text = " Thêm mới";
            this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
            // 
            // tsmUpdateFood
            // 
            this.tsmUpdateFood.Name = "tsmUpdateFood";
            this.tsmUpdateFood.Size = new System.Drawing.Size(218, 22);
            this.tsmUpdateFood.Text = "Cập nhật thông tin món ăn";
            this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(71, 360);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(16, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "...";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(203, 360);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(16, 13);
            this.lblCatName.TabIndex = 3;
            this.lblCatName.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Có tất cả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "món ăn thuộc nhóm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm kiếm theo tên:";
            // 
            // txtTimTheoTen
            // 
            this.txtTimTheoTen.Location = new System.Drawing.Point(513, 13);
            this.txtTimTheoTen.Name = "txtTimTheoTen";
            this.txtTimTheoTen.Size = new System.Drawing.Size(100, 20);
            this.txtTimTheoTen.TabIndex = 7;
            this.txtTimTheoTen.TextChanged += new System.EventHandler(this.txtTimTheoTen_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 382);
            this.Controls.Add(this.txtTimTheoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.lbChonNhomMonAn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChonNhomMonAn;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
        private System.Windows.Forms.ToolStripMenuItem tsmSeperator;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimTheoTen;
    }
}

