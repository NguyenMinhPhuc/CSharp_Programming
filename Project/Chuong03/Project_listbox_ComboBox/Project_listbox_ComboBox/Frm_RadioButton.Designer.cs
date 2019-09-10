namespace Project_listbox_ComboBox
{
    partial class Frm_RadioButton
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
            this.lbllop = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.grpNganh = new System.Windows.Forms.GroupBox();
            this.rdbHeThongThongTin = new System.Windows.Forms.RadioButton();
            this.rdbMangMayTinh = new System.Windows.Forms.RadioButton();
            this.rdbKyThuatMayTinh = new System.Windows.Forms.RadioButton();
            this.rdbCongNghePhanMem = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpNganh.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllop
            // 
            this.lbllop.AutoSize = true;
            this.lbllop.Location = new System.Drawing.Point(124, 105);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(54, 26);
            this.lbllop.TabIndex = 8;
            this.lbllop.Text = "Lớp:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(184, 102);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(244, 32);
            this.txtKhoa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập họ và tên:";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(184, 64);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(244, 32);
            this.txtHovaTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(932, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Location = new System.Drawing.Point(18, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(132, 31);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(58, 30);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(34, 32);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(77, 30);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // grpNganh
            // 
            this.grpNganh.Controls.Add(this.rdbHeThongThongTin);
            this.grpNganh.Controls.Add(this.rdbMangMayTinh);
            this.grpNganh.Controls.Add(this.rdbKyThuatMayTinh);
            this.grpNganh.Controls.Add(this.rdbCongNghePhanMem);
            this.grpNganh.Location = new System.Drawing.Point(18, 213);
            this.grpNganh.Name = "grpNganh";
            this.grpNganh.Size = new System.Drawing.Size(410, 183);
            this.grpNganh.TabIndex = 11;
            this.grpNganh.TabStop = false;
            this.grpNganh.Text = "Chọn ngành học";
            // 
            // rdbHeThongThongTin
            // 
            this.rdbHeThongThongTin.AutoSize = true;
            this.rdbHeThongThongTin.Location = new System.Drawing.Point(34, 140);
            this.rdbHeThongThongTin.Name = "rdbHeThongThongTin";
            this.rdbHeThongThongTin.Size = new System.Drawing.Size(207, 30);
            this.rdbHeThongThongTin.TabIndex = 3;
            this.rdbHeThongThongTin.TabStop = true;
            this.rdbHeThongThongTin.Text = "Hệ thống thông tin";
            this.rdbHeThongThongTin.UseVisualStyleBackColor = true;
            // 
            // rdbMangMayTinh
            // 
            this.rdbMangMayTinh.AutoSize = true;
            this.rdbMangMayTinh.Location = new System.Drawing.Point(34, 103);
            this.rdbMangMayTinh.Name = "rdbMangMayTinh";
            this.rdbMangMayTinh.Size = new System.Drawing.Size(340, 30);
            this.rdbMangMayTinh.TabIndex = 2;
            this.rdbMangMayTinh.TabStop = true;
            this.rdbMangMayTinh.Text = "Mạng máy tính vào truyền thông";
            this.rdbMangMayTinh.UseVisualStyleBackColor = true;
            // 
            // rdbKyThuatMayTinh
            // 
            this.rdbKyThuatMayTinh.AutoSize = true;
            this.rdbKyThuatMayTinh.Location = new System.Drawing.Point(34, 67);
            this.rdbKyThuatMayTinh.Name = "rdbKyThuatMayTinh";
            this.rdbKyThuatMayTinh.Size = new System.Drawing.Size(199, 30);
            this.rdbKyThuatMayTinh.TabIndex = 1;
            this.rdbKyThuatMayTinh.TabStop = true;
            this.rdbKyThuatMayTinh.Text = "Kỹ thuật máy tính";
            this.rdbKyThuatMayTinh.UseVisualStyleBackColor = true;
            // 
            // rdbCongNghePhanMem
            // 
            this.rdbCongNghePhanMem.AutoSize = true;
            this.rdbCongNghePhanMem.Location = new System.Drawing.Point(34, 31);
            this.rdbCongNghePhanMem.Name = "rdbCongNghePhanMem";
            this.rdbCongNghePhanMem.Size = new System.Drawing.Size(253, 30);
            this.rdbCongNghePhanMem.TabIndex = 0;
            this.rdbCongNghePhanMem.TabStop = true;
            this.rdbCongNghePhanMem.Text = "Công nghệ phầm mềm";
            this.rdbCongNghePhanMem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNoiDung);
            this.groupBox3.Location = new System.Drawing.Point(446, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 332);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nội dung sinh viên đăng ký";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(6, 31);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(445, 295);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.Text = "";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(52, 415);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(125, 43);
            this.btnDangKy.TabIndex = 13;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(214, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 43);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_RadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 470);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpNganh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllop);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHovaTen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_RadioButton";
            this.Text = "Frm_RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpNganh.ResumeLayout(false);
            this.grpNganh.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.GroupBox grpNganh;
        private System.Windows.Forms.RadioButton rdbHeThongThongTin;
        private System.Windows.Forms.RadioButton rdbMangMayTinh;
        private System.Windows.Forms.RadioButton rdbKyThuatMayTinh;
        private System.Windows.Forms.RadioButton rdbCongNghePhanMem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
    }
}