namespace Project20190819
{
    partial class FrmViDu03_01
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
            this.txtNumber01 = new System.Windows.Forms.TextBox();
            this.txtNumber02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtPhepToan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số 1: ";
            // 
            // txtNumber01
            // 
            this.txtNumber01.Location = new System.Drawing.Point(157, 11);
            this.txtNumber01.Name = "txtNumber01";
            this.txtNumber01.Size = new System.Drawing.Size(472, 35);
            this.txtNumber01.TabIndex = 0;
            this.txtNumber01.Text = "0";
            this.txtNumber01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumber01.TextChanged += new System.EventHandler(this.txtNumber01_TextChanged);
            this.txtNumber01.Enter += new System.EventHandler(this.txtNumber01_Enter);
            this.txtNumber01.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber01_KeyDown);
            this.txtNumber01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber01_KeyPress);
            this.txtNumber01.Leave += new System.EventHandler(this.txtNumber01_Leave);
            // 
            // txtNumber02
            // 
            this.txtNumber02.Location = new System.Drawing.Point(157, 52);
            this.txtNumber02.Name = "txtNumber02";
            this.txtNumber02.Size = new System.Drawing.Size(472, 35);
            this.txtNumber02.TabIndex = 1;
            this.txtNumber02.Text = "0";
            this.txtNumber02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumber02.TextChanged += new System.EventHandler(this.txtNumber02_TextChanged);
            this.txtNumber02.Enter += new System.EventHandler(this.txtNumber02_Enter);
            this.txtNumber02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber02_KeyDown);
            this.txtNumber02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber02_KeyPress);
            this.txtNumber02.Leave += new System.EventHandler(this.txtNumber02_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số 2: ";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(509, 93);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(120, 35);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtPhepToan
            // 
            this.txtPhepToan.Location = new System.Drawing.Point(157, 93);
            this.txtPhepToan.Name = "txtPhepToan";
            this.txtPhepToan.Size = new System.Drawing.Size(346, 35);
            this.txtPhepToan.TabIndex = 2;
            this.txtPhepToan.Text = "+";
            this.txtPhepToan.TextChanged += new System.EventHandler(this.txtPhepToan_TextChanged);
            this.txtPhepToan.Enter += new System.EventHandler(this.txtPhepToan_Enter);
            this.txtPhepToan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhepToan_KeyDown);
            this.txtPhepToan.Leave += new System.EventHandler(this.txtPhepToan_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phép toán: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(152, 131);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 29);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "N/A";
            // 
            // FrmViDu03_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 179);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPhepToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtNumber02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber01);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmViDu03_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViDu03_01";
            this.Load += new System.EventHandler(this.FrmViDu03_01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber01;
        private System.Windows.Forms.TextBox txtNumber02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtPhepToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
     
    }
}