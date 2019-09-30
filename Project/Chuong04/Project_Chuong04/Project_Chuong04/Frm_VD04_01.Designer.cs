namespace Project_Chuong04
{
    partial class Frm_VD04_01
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
            this.components = new System.ComponentModel.Container();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblerr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ttpDangNhap = new System.Windows.Forms.ToolTip(this.components);
            this.ttpMatKhau = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.LoiTenDN = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoiMatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.LoiTenDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoiMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(147, 159);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(177, 51);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(147, 75);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(400, 36);
            this.txtTaiKhoan.TabIndex = 0;
            this.ttpDangNhap.SetToolTip(this.txtTaiKhoan, "Nhập chuỗi ký không dấu, không khoảng trắng");
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(147, 117);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '@';
            this.txtMatKhau.Size = new System.Drawing.Size(400, 36);
            this.txtMatKhau.TabIndex = 1;
            this.ttpMatKhau.SetToolTip(this.txtMatKhau, "Nhập ít nhất 6 ký tự, nhiều nhất 10 ký tự");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(370, 159);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 51);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(762, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblerr
            // 
            this.lblerr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblerr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblerr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerr.ForeColor = System.Drawing.Color.White;
            this.lblerr.Location = new System.Drawing.Point(0, 217);
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(762, 65);
            this.lblerr.TabIndex = 7;
            this.lblerr.Text = "...";
            this.lblerr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(752, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 152);
            this.label5.TabIndex = 8;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 152);
            this.label6.TabIndex = 9;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttpDangNhap
            // 
            this.ttpDangNhap.AutomaticDelay = 50;
            this.ttpDangNhap.AutoPopDelay = 2000;
            this.ttpDangNhap.BackColor = System.Drawing.Color.Fuchsia;
            this.ttpDangNhap.InitialDelay = 50;
            this.ttpDangNhap.IsBalloon = true;
            this.ttpDangNhap.ReshowDelay = 10;
            this.ttpDangNhap.ShowAlways = true;
            this.ttpDangNhap.Tag = "Nhập chuỗi ký không dấu, không khoảng trắng";
            this.ttpDangNhap.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpDangNhap.ToolTipTitle = "Thông báo";
            // 
            // ttpMatKhau
            // 
            this.ttpMatKhau.AutomaticDelay = 50;
            this.ttpMatKhau.AutoPopDelay = 2000;
            this.ttpMatKhau.BackColor = System.Drawing.Color.Fuchsia;
            this.ttpMatKhau.InitialDelay = 50;
            this.ttpMatKhau.IsBalloon = true;
            this.ttpMatKhau.OwnerDraw = true;
            this.ttpMatKhau.ReshowDelay = 10;
            this.ttpMatKhau.ShowAlways = true;
            this.ttpMatKhau.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttpMatKhau.ToolTipTitle = "Thông báo";
            this.ttpMatKhau.UseAnimation = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // LoiTenDN
            // 
            this.LoiTenDN.ContainerControl = this;
            // 
            // LoiMatKhau
            // 
            this.LoiMatKhau.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(147, 228);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // Frm_VD04_01
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 282);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblerr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangNhap);
            this.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.helpProvider1.SetHelpString(this, "Hien Thi noi dung huong dan");
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Frm_VD04_01";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_VD04_01";
            this.Load += new System.EventHandler(this.Frm_VD04_01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoiTenDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoiMatKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblerr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip ttpDangNhap;
        private System.Windows.Forms.ToolTip ttpMatKhau;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider LoiTenDN;
        private System.Windows.Forms.ErrorProvider LoiMatKhau;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}