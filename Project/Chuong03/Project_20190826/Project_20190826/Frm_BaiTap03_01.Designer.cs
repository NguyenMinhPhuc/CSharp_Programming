namespace Project_20190826
{
    partial class Frm_BaiTap03_01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxNumber = new System.Windows.Forms.TextBox();
            this.txtMinNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số nhập vào";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(47, 45);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(183, 32);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(304, 45);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(183, 32);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(550, 45);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(183, 32);
            this.txtC.TabIndex = 2;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMinNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaxNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lớn nhất";
            // 
            // txtMaxNumber
            // 
            this.txtMaxNumber.Enabled = false;
            this.txtMaxNumber.Location = new System.Drawing.Point(144, 45);
            this.txtMaxNumber.Name = "txtMaxNumber";
            this.txtMaxNumber.Size = new System.Drawing.Size(179, 32);
            this.txtMaxNumber.TabIndex = 1;
            // 
            // txtMinNumber
            // 
            this.txtMinNumber.Enabled = false;
            this.txtMinNumber.Location = new System.Drawing.Point(531, 42);
            this.txtMinNumber.Name = "txtMinNumber";
            this.txtMinNumber.Size = new System.Drawing.Size(179, 32);
            this.txtMinNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(403, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số nhỏ nhất";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(280, 134);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(238, 54);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Frm_BaiTap03_01
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 326);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_BaiTap03_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BaiTap03_01";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMinNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTim;
    }
}