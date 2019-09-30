namespace Project_BaiTapChuong03
{
    partial class Frm_BaiTap06
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
            this.lbDanhSachMon = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDanhSachThucDon = new System.Windows.Forms.ListBox();
            this.btnChonMon = new System.Windows.Forms.Button();
            this.btnHuyMon = new System.Windows.Forms.Button();
            this.btnChonHet = new System.Windows.Forms.Button();
            this.btnHuyHet = new System.Windows.Forms.Button();
            this.btnInThucDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDanhSachMon
            // 
            this.lbDanhSachMon.FormattingEnabled = true;
            this.lbDanhSachMon.ItemHeight = 25;
            this.lbDanhSachMon.Location = new System.Drawing.Point(12, 124);
            this.lbDanhSachMon.Name = "lbDanhSachMon";
            this.lbDanhSachMon.Size = new System.Drawing.Size(206, 304);
            this.lbDanhSachMon.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(723, 52);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm số chính phương trong dãy";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(723, 24);
            this.label6.TabIndex = 14;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách món";
            // 
            // lbDanhSachThucDon
            // 
            this.lbDanhSachThucDon.FormattingEnabled = true;
            this.lbDanhSachThucDon.ItemHeight = 25;
            this.lbDanhSachThucDon.Location = new System.Drawing.Point(456, 124);
            this.lbDanhSachThucDon.Name = "lbDanhSachThucDon";
            this.lbDanhSachThucDon.Size = new System.Drawing.Size(253, 304);
            this.lbDanhSachThucDon.TabIndex = 16;
            // 
            // btnChonMon
            // 
            this.btnChonMon.Location = new System.Drawing.Point(277, 124);
            this.btnChonMon.Name = "btnChonMon";
            this.btnChonMon.Size = new System.Drawing.Size(104, 50);
            this.btnChonMon.TabIndex = 17;
            this.btnChonMon.Text = ">";
            this.btnChonMon.UseVisualStyleBackColor = true;
            this.btnChonMon.Click += new System.EventHandler(this.btnChonMon_Click);
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.Location = new System.Drawing.Point(277, 177);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(104, 50);
            this.btnHuyMon.TabIndex = 18;
            this.btnHuyMon.Text = "<";
            this.btnHuyMon.UseVisualStyleBackColor = true;
            this.btnHuyMon.Click += new System.EventHandler(this.btnHuyMon_Click);
            // 
            // btnChonHet
            // 
            this.btnChonHet.Location = new System.Drawing.Point(277, 233);
            this.btnChonHet.Name = "btnChonHet";
            this.btnChonHet.Size = new System.Drawing.Size(104, 50);
            this.btnChonHet.TabIndex = 19;
            this.btnChonHet.Text = ">>";
            this.btnChonHet.UseVisualStyleBackColor = true;
            this.btnChonHet.Click += new System.EventHandler(this.btnChonHet_Click);
            // 
            // btnHuyHet
            // 
            this.btnHuyHet.Location = new System.Drawing.Point(277, 289);
            this.btnHuyHet.Name = "btnHuyHet";
            this.btnHuyHet.Size = new System.Drawing.Size(104, 50);
            this.btnHuyHet.TabIndex = 20;
            this.btnHuyHet.Text = "<<";
            this.btnHuyHet.UseVisualStyleBackColor = true;
            this.btnHuyHet.Click += new System.EventHandler(this.btnHuyHet_Click);
            // 
            // btnInThucDon
            // 
            this.btnInThucDon.Location = new System.Drawing.Point(224, 377);
            this.btnInThucDon.Name = "btnInThucDon";
            this.btnInThucDon.Size = new System.Drawing.Size(127, 51);
            this.btnInThucDon.TabIndex = 21;
            this.btnInThucDon.Text = "In thực đơn";
            this.btnInThucDon.UseVisualStyleBackColor = true;
            this.btnInThucDon.Click += new System.EventHandler(this.btnInThucDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(357, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 51);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Danh sách thực đơn ngày";
            // 
            // Frm_BaiTap06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInThucDon);
            this.Controls.Add(this.btnHuyHet);
            this.Controls.Add(this.btnChonHet);
            this.Controls.Add(this.btnHuyMon);
            this.Controls.Add(this.btnChonMon);
            this.Controls.Add(this.lbDanhSachThucDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDanhSachMon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_BaiTap06";
            this.Text = "Frm_BaiTap06";
            this.Load += new System.EventHandler(this.Frm_BaiTap06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhSachMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDanhSachThucDon;
        private System.Windows.Forms.Button btnChonMon;
        private System.Windows.Forms.Button btnHuyMon;
        private System.Windows.Forms.Button btnChonHet;
        private System.Windows.Forms.Button btnHuyHet;
        private System.Windows.Forms.Button btnInThucDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
    }
}