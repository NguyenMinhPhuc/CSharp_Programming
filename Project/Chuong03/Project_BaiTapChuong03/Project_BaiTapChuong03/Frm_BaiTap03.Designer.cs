namespace Project_BaiTapChuong03
{
    partial class Frm_BaiTap03
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
            this.txtHeSoA = new System.Windows.Forms.TextBox();
            this.txtHeSoB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeSoC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiaiPhuongTrinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNghiem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập hệ số A:";
            // 
            // txtHeSoA
            // 
            this.txtHeSoA.Location = new System.Drawing.Point(165, 79);
            this.txtHeSoA.Name = "txtHeSoA";
            this.txtHeSoA.Size = new System.Drawing.Size(359, 32);
            this.txtHeSoA.TabIndex = 1;
            this.txtHeSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeSoA_KeyPress);
            // 
            // txtHeSoB
            // 
            this.txtHeSoB.Location = new System.Drawing.Point(165, 134);
            this.txtHeSoB.Name = "txtHeSoB";
            this.txtHeSoB.Size = new System.Drawing.Size(359, 32);
            this.txtHeSoB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập hệ số B:";
            // 
            // txtHeSoC
            // 
            this.txtHeSoC.Location = new System.Drawing.Point(165, 188);
            this.txtHeSoC.Name = "txtHeSoC";
            this.txtHeSoC.Size = new System.Drawing.Size(359, 32);
            this.txtHeSoC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập hệ số C:";
            // 
            // btnGiaiPhuongTrinh
            // 
            this.btnGiaiPhuongTrinh.Location = new System.Drawing.Point(549, 79);
            this.btnGiaiPhuongTrinh.Name = "btnGiaiPhuongTrinh";
            this.btnGiaiPhuongTrinh.Size = new System.Drawing.Size(103, 65);
            this.btnGiaiPhuongTrinh.TabIndex = 6;
            this.btnGiaiPhuongTrinh.Text = "Giải";
            this.btnGiaiPhuongTrinh.UseVisualStyleBackColor = true;
            this.btnGiaiPhuongTrinh.Click += new System.EventHandler(this.btnGiaiPhuongTrinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(549, 155);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 65);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nghiệm phương trình:";
            // 
            // lblNghiem
            // 
            this.lblNghiem.AutoSize = true;
            this.lblNghiem.Location = new System.Drawing.Point(12, 312);
            this.lblNghiem.Name = "lblNghiem";
            this.lblNghiem.Size = new System.Drawing.Size(250, 26);
            this.lblNghiem.TabIndex = 9;
            this.lblNghiem.Text = "----------------------------------";
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
            this.label5.Size = new System.Drawing.Size(665, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giải Phương trình bậc 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(665, 52);
            this.label6.TabIndex = 11;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_BaiTap03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 414);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNghiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiPhuongTrinh);
            this.Controls.Add(this.txtHeSoC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeSoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeSoA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_BaiTap03";
            this.Text = "Frm_BaiTap03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeSoA;
        private System.Windows.Forms.TextBox txtHeSoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeSoC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiaiPhuongTrinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNghiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}