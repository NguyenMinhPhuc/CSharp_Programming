namespace Project_listbox_ComboBox
{
    partial class Frm_ViDuComboBox
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
            this.cboMau = new System.Windows.Forms.ComboBox();
            this.lblChuQuyen = new System.Windows.Forms.Label();
            this.btnDoiMau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMau
            // 
            this.cboMau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMau.FormattingEnabled = true;
            this.cboMau.Location = new System.Drawing.Point(15, 13);
            this.cboMau.Margin = new System.Windows.Forms.Padding(6);
            this.cboMau.Name = "cboMau";
            this.cboMau.Size = new System.Drawing.Size(270, 33);
            this.cboMau.TabIndex = 0;
            this.cboMau.SelectedIndexChanged += new System.EventHandler(this.cboMau_SelectedIndexChanged);
            this.cboMau.SelectionChangeCommitted += new System.EventHandler(this.cboMau_SelectionChangeCommitted);
            // 
            // lblChuQuyen
            // 
            this.lblChuQuyen.AutoSize = true;
            this.lblChuQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuQuyen.Location = new System.Drawing.Point(12, 52);
            this.lblChuQuyen.Name = "lblChuQuyen";
            this.lblChuQuyen.Size = new System.Drawing.Size(472, 31);
            this.lblChuQuyen.TabIndex = 1;
            this.lblChuQuyen.Text = "Trường Sa, Hoàng Sa là của Việt Nam";
            // 
            // btnDoiMau
            // 
            this.btnDoiMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btnDoiMau.FlatAppearance.BorderSize = 0;
            this.btnDoiMau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDoiMau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMau.Location = new System.Drawing.Point(294, 13);
            this.btnDoiMau.Name = "btnDoiMau";
            this.btnDoiMau.Size = new System.Drawing.Size(126, 33);
            this.btnDoiMau.TabIndex = 2;
            this.btnDoiMau.Text = "Đổi màu";
            this.btnDoiMau.UseVisualStyleBackColor = false;
            this.btnDoiMau.Click += new System.EventHandler(this.btnDoiMau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(426, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_ViDuComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 87);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMau);
            this.Controls.Add(this.lblChuQuyen);
            this.Controls.Add(this.cboMau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_ViDuComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ví dụ 03_05";
            this.Load += new System.EventHandler(this.Frm_ViDuComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMau;
        private System.Windows.Forms.Label lblChuQuyen;
        private System.Windows.Forms.Button btnDoiMau;
        private System.Windows.Forms.Button btnThoat;
    }
}