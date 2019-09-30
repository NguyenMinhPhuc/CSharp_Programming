namespace Project_Chuong04
{
    partial class Frm_Main
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
            this.btnViDu04_01 = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.btnChonMon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViDu04_01
            // 
            this.btnViDu04_01.Location = new System.Drawing.Point(46, 34);
            this.btnViDu04_01.Name = "btnViDu04_01";
            this.btnViDu04_01.Size = new System.Drawing.Size(155, 49);
            this.btnViDu04_01.TabIndex = 0;
            this.btnViDu04_01.Text = "Ví dụ 04_01";
            this.btnViDu04_01.UseVisualStyleBackColor = true;
            this.btnViDu04_01.Click += new System.EventHandler(this.btnViDu04_01_Click);
            // 
            // btnListView
            // 
            this.btnListView.Location = new System.Drawing.Point(46, 89);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(155, 49);
            this.btnListView.TabIndex = 1;
            this.btnListView.Text = "List View";
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnChonMon
            // 
            this.btnChonMon.Location = new System.Drawing.Point(46, 144);
            this.btnChonMon.Name = "btnChonMon";
            this.btnChonMon.Size = new System.Drawing.Size(155, 49);
            this.btnChonMon.TabIndex = 2;
            this.btnChonMon.Text = "Bài tập chọn món";
            this.btnChonMon.UseVisualStyleBackColor = true;
            this.btnChonMon.Click += new System.EventHandler(this.btnChonMon_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 452);
            this.Controls.Add(this.btnChonMon);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.btnViDu04_01);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViDu04_01;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.Button btnChonMon;
    }
}

