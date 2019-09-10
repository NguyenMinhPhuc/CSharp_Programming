namespace Project_listbox_ComboBox
{
    partial class FrmViDuComboBox02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ( )
        {
            this.lsbSanPham = new System.Windows.Forms.ListBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSanPhamCbo = new System.Windows.Forms.TextBox();
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemViTri = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnXoaDanhSachSanPham = new System.Windows.Forms.Button();
            this.btnThemDuLieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbSanPham
            // 
            this.lsbSanPham.FormattingEnabled = true;
            this.lsbSanPham.ItemHeight = 25;
            this.lsbSanPham.Location = new System.Drawing.Point(12, 27);
            this.lsbSanPham.Name = "lsbSanPham";
            this.lsbSanPham.Size = new System.Drawing.Size(194, 279);
            this.lsbSanPham.TabIndex = 0;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(212, 56);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(202, 32);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(420, 56);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPhamCbo
            // 
            this.txtTenSanPhamCbo.Location = new System.Drawing.Point(212, 120);
            this.txtTenSanPhamCbo.Name = "txtTenSanPhamCbo";
            this.txtTenSanPhamCbo.Size = new System.Drawing.Size(202, 32);
            this.txtTenSanPhamCbo.TabIndex = 4;
            // 
            // cboViTri
            // 
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Location = new System.Drawing.Point(420, 118);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(105, 33);
            this.cboViTri.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vị trí:";
            // 
            // btnThemViTri
            // 
            this.btnThemViTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemViTri.FlatAppearance.BorderSize = 0;
            this.btnThemViTri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThemViTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemViTri.ForeColor = System.Drawing.Color.White;
            this.btnThemViTri.Location = new System.Drawing.Point(531, 117);
            this.btnThemViTri.Name = "btnThemViTri";
            this.btnThemViTri.Size = new System.Drawing.Size(207, 36);
            this.btnThemViTri.TabIndex = 8;
            this.btnThemViTri.Text = "Thêm theo combo";
            this.btnThemViTri.UseVisualStyleBackColor = false;
            this.btnThemViTri.Click += new System.EventHandler(this.btnThemViTri_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Olive;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(531, 185);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(207, 36);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Thêm theo combo";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập sản phẩm cần tìm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(212, 189);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(313, 32);
            this.txtTim.TabIndex = 11;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoaSanPham.FlatAppearance.BorderSize = 0;
            this.btnXoaSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXoaSanPham.Location = new System.Drawing.Point(212, 270);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(207, 36);
            this.btnXoaSanPham.TabIndex = 12;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // btnXoaDanhSachSanPham
            // 
            this.btnXoaDanhSachSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoaDanhSachSanPham.FlatAppearance.BorderSize = 0;
            this.btnXoaDanhSachSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoaDanhSachSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDanhSachSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXoaDanhSachSanPham.Location = new System.Drawing.Point(425, 270);
            this.btnXoaDanhSachSanPham.Name = "btnXoaDanhSachSanPham";
            this.btnXoaDanhSachSanPham.Size = new System.Drawing.Size(313, 36);
            this.btnXoaDanhSachSanPham.TabIndex = 13;
            this.btnXoaDanhSachSanPham.Text = "Xóa danh sách sản phẩm";
            this.btnXoaDanhSachSanPham.UseVisualStyleBackColor = false;
            this.btnXoaDanhSachSanPham.Click += new System.EventHandler(this.btnXoaDanhSachSanPham_Click);
            // 
            // btnThemDuLieu
            // 
            this.btnThemDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemDuLieu.FlatAppearance.BorderSize = 0;
            this.btnThemDuLieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThemDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDuLieu.ForeColor = System.Drawing.Color.White;
            this.btnThemDuLieu.Location = new System.Drawing.Point(420, 12);
            this.btnThemDuLieu.Name = "btnThemDuLieu";
            this.btnThemDuLieu.Size = new System.Drawing.Size(318, 32);
            this.btnThemDuLieu.TabIndex = 14;
            this.btnThemDuLieu.Text = "Thêm dữ liệu tự động";
            this.btnThemDuLieu.UseVisualStyleBackColor = false;
            this.btnThemDuLieu.Click += new System.EventHandler(this.btnThemDuLieu_Click);
            // 
            // FrmViDuComboBox02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 314);
            this.Controls.Add(this.btnThemDuLieu);
            this.Controls.Add(this.btnXoaDanhSachSanPham);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemViTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboViTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSanPhamCbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.lsbSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmViDuComboBox02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa sản phẩm";
            this.Load += new System.EventHandler(this.FrmViDuComboBox02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSanPhamCbo;
        private System.Windows.Forms.ComboBox cboViTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemViTri;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnXoaDanhSachSanPham;
        private System.Windows.Forms.Button btnThemDuLieu;
    }
}