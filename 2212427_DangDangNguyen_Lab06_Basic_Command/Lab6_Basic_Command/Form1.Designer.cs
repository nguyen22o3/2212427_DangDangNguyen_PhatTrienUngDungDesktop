namespace Lab6_Basic_Command
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
            this.button1 = new System.Windows.Forms.Button();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTenNhomThucAn = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lấy danh sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
            this.lvCategory.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(0, 189);
            this.lvCategory.MultiSelect = false;
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(800, 261);
            this.lvCategory.TabIndex = 1;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
            // 
            // chID
            // 
            this.chID.Text = "Mã loại";
            // 
            // chName
            // 
            this.chName.Text = "Tên loại món ăn";
            this.chName.Width = 501;
            // 
            // chType
            // 
            this.chType.Text = "Loại";
            this.chType.Width = 235;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(12, 24);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(54, 13);
            this.lblMa.TabIndex = 2;
            this.lblMa.Text = "Mã nhóm:";
            // 
            // lblTenNhomThucAn
            // 
            this.lblTenNhomThucAn.AutoSize = true;
            this.lblTenNhomThucAn.Location = new System.Drawing.Point(12, 72);
            this.lblTenNhomThucAn.Name = "lblTenNhomThucAn";
            this.lblTenNhomThucAn.Size = new System.Drawing.Size(97, 13);
            this.lblTenNhomThucAn.TabIndex = 2;
            this.lblTenNhomThucAn.Text = "Tên nhóm thức ăn:";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(12, 121);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(30, 13);
            this.lblLoai.TabIndex = 2;
            this.lblLoai.Text = "Loại:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(273, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(127, 114);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(273, 20);
            this.txtType.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(397, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 35);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(569, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 35);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(199, 22);
            this.tsmDelete.Text = "Xóa nhóm sản phẩm";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmViewFood
            // 
            this.tsmViewFood.Name = "tsmViewFood";
            this.tsmViewFood.Size = new System.Drawing.Size(199, 22);
            this.tsmViewFood.Text = "Xem danh sách món ăn";
            this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblTenNhomThucAn);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTenNhomThucAn;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
    }
}

