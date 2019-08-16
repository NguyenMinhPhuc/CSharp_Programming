namespace Project_20190816
{
    partial class Frm_VD_03_02
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
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.btnHienThi = new Project_20190816.CircleButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.circleButton1 = new Project_20190816.CircleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(179, 131);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(336, 37);
            this.lblNoiDung.TabIndex = 1;
            this.lblNoiDung.Text = "---hiển thị nội dung---";
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.Salmon;
            this.btnHienThi.FlatAppearance.BorderSize = 0;
            this.btnHienThi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.White;
            this.btnHienThi.Location = new System.Drawing.Point(186, 230);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 100);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(353, 230);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 49);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.Color.Lime;
            this.btnNumber.FlatAppearance.BorderSize = 0;
            this.btnNumber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber.Location = new System.Drawing.Point(39, 181);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(100, 60);
            this.btnNumber.TabIndex = 2;
            this.btnNumber.Text = "Click 01";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.Purple;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.circleButton1.ForeColor = System.Drawing.Color.White;
            this.circleButton1.Image = global::Project_20190816.Properties.Resources.icons8_save_32;
            this.circleButton1.Location = new System.Drawing.Point(522, 198);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(50, 50);
            this.circleButton1.TabIndex = 3;
            this.circleButton1.UseVisualStyleBackColor = false;
            // 
            // Frm_VD_03_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 390);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.label1);
            this.Name = "Frm_VD_03_02";
            this.Text = "Frm_VD_03_02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoiDung;
        private CircleButton btnHienThi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNumber;
        private CircleButton circleButton1;
    }
}