namespace Project_20190816
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
            this.btnViDu_03_01 = new System.Windows.Forms.Button();
            this.btnFunc03_012 = new System.Windows.Forms.Button();
            this.btnFunc_03_02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViDu_03_01
            // 
            this.btnViDu_03_01.Location = new System.Drawing.Point(27, 24);
            this.btnViDu_03_01.Name = "btnViDu_03_01";
            this.btnViDu_03_01.Size = new System.Drawing.Size(82, 29);
            this.btnViDu_03_01.TabIndex = 0;
            this.btnViDu_03_01.Text = "Func_03_01";
            this.btnViDu_03_01.UseVisualStyleBackColor = true;
            this.btnViDu_03_01.Click += new System.EventHandler(this.btnViDu_03_01_Click);
            // 
            // btnFunc03_012
            // 
            this.btnFunc03_012.Location = new System.Drawing.Point(140, 29);
            this.btnFunc03_012.Name = "btnFunc03_012";
            this.btnFunc03_012.Size = new System.Drawing.Size(110, 23);
            this.btnFunc03_012.TabIndex = 1;
            this.btnFunc03_012.Text = "Func_03_012";
            this.btnFunc03_012.UseVisualStyleBackColor = true;
            this.btnFunc03_012.Click += new System.EventHandler(this.btnFunc03_012_Click);
            // 
            // btnFunc_03_02
            // 
            this.btnFunc_03_02.Location = new System.Drawing.Point(291, 29);
            this.btnFunc_03_02.Name = "btnFunc_03_02";
            this.btnFunc_03_02.Size = new System.Drawing.Size(75, 23);
            this.btnFunc_03_02.TabIndex = 2;
            this.btnFunc_03_02.Text = "Func_03_02";
            this.btnFunc_03_02.UseVisualStyleBackColor = true;
            this.btnFunc_03_02.Click += new System.EventHandler(this.btnFunc_03_02_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 339);
            this.Controls.Add(this.btnFunc_03_02);
            this.Controls.Add(this.btnFunc03_012);
            this.Controls.Add(this.btnViDu_03_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2019 - 08 - 16";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load_1);
            this.Click += new System.EventHandler(this.Frm_Main_Click);
            this.DoubleClick += new System.EventHandler(this.Frm_Main_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViDu_03_01;
        private System.Windows.Forms.Button btnFunc03_012;
        private System.Windows.Forms.Button btnFunc_03_02;
    }
}

