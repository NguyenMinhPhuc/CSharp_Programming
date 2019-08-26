namespace Project_20190826
{
    partial class Frm_BaiTap03_07
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberN = new System.Windows.Forms.TextBox();
            this.txtNumberX = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHienThi01 = new System.Windows.Forms.TextBox();
            this.txtHienThi02 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHienThi03 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào số tự nhiên N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập vào số thực X:";
            // 
            // txtNumberN
            // 
            this.txtNumberN.Location = new System.Drawing.Point(260, 12);
            this.txtNumberN.Name = "txtNumberN";
            this.txtNumberN.Size = new System.Drawing.Size(401, 32);
            this.txtNumberN.TabIndex = 2;
            this.txtNumberN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberN_KeyPress);
            // 
            // txtNumberX
            // 
            this.txtNumberX.Location = new System.Drawing.Point(260, 50);
            this.txtNumberX.Name = "txtNumberX";
            this.txtNumberX.Size = new System.Drawing.Size(401, 32);
            this.txtNumberX.TabIndex = 2;
            this.txtNumberX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberX_KeyPress);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTinhTong.Location = new System.Drawing.Point(668, 12);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(161, 70);
            this.btnTinhTong.TabIndex = 3;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHienThi03);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHienThi02);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHienThi01);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(14, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "S=";
            // 
            // txtHienThi01
            // 
            this.txtHienThi01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHienThi01.Location = new System.Drawing.Point(53, 31);
            this.txtHienThi01.Name = "txtHienThi01";
            this.txtHienThi01.Size = new System.Drawing.Size(756, 32);
            this.txtHienThi01.TabIndex = 1;
            // 
            // txtHienThi02
            // 
            this.txtHienThi02.ForeColor = System.Drawing.Color.Red;
            this.txtHienThi02.Location = new System.Drawing.Point(53, 69);
            this.txtHienThi02.Name = "txtHienThi02";
            this.txtHienThi02.Size = new System.Drawing.Size(756, 32);
            this.txtHienThi02.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "S=";
            // 
            // txtHienThi03
            // 
            this.txtHienThi03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHienThi03.Location = new System.Drawing.Point(53, 107);
            this.txtHienThi03.Name = "txtHienThi03";
            this.txtHienThi03.Size = new System.Drawing.Size(756, 32);
            this.txtHienThi03.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "S=";
            // 
            // txtKetQua
            // 
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(53, 145);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(756, 32);
            this.txtKetQua.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "S=";
            // 
            // Frm_BaiTap03_07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtNumberX);
            this.Controls.Add(this.txtNumberN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_BaiTap03_07";
            this.Text = "Frm_BaiTap03_07";
            this.Load += new System.EventHandler(this.Frm_BaiTap03_07_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberN;
        private System.Windows.Forms.TextBox txtNumberX;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHienThi03;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHienThi02;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHienThi01;
        private System.Windows.Forms.Label label3;
    }
}