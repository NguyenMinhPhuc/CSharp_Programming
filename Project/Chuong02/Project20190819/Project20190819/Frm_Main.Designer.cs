namespace Project20190819
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
            this.btnViDu3 = new System.Windows.Forms.Button();
            this.btnViDu0301 = new System.Windows.Forms.Button();
            this.btnViDu3_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViDu3
            // 
            this.btnViDu3.Location = new System.Drawing.Point(69, 24);
            this.btnViDu3.Name = "btnViDu3";
            this.btnViDu3.Size = new System.Drawing.Size(137, 53);
            this.btnViDu3.TabIndex = 0;
            this.btnViDu3.Text = "Ví dụ 3_Trang76";
            this.btnViDu3.UseVisualStyleBackColor = true;
            this.btnViDu3.Click += new System.EventHandler(this.btnViDu3_Click);
            // 
            // btnViDu0301
            // 
            this.btnViDu0301.Location = new System.Drawing.Point(246, 24);
            this.btnViDu0301.Name = "btnViDu0301";
            this.btnViDu0301.Size = new System.Drawing.Size(137, 53);
            this.btnViDu0301.TabIndex = 0;
            this.btnViDu0301.Text = "Ví dụ 3_01";
            this.btnViDu0301.UseVisualStyleBackColor = true;
            this.btnViDu0301.Click += new System.EventHandler(this.btnViDu0301_Click);
            // 
            // btnViDu3_4
            // 
            this.btnViDu3_4.Location = new System.Drawing.Point(408, 24);
            this.btnViDu3_4.Name = "btnViDu3_4";
            this.btnViDu3_4.Size = new System.Drawing.Size(121, 53);
            this.btnViDu3_4.TabIndex = 1;
            this.btnViDu3_4.Text = "Ví dụ 3_4";
            this.btnViDu3_4.UseVisualStyleBackColor = true;
            this.btnViDu3_4.Click += new System.EventHandler(this.btnViDu3_4_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 357);
            this.Controls.Add(this.btnViDu3_4);
            this.Controls.Add(this.btnViDu0301);
            this.Controls.Add(this.btnViDu3);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViDu3;
        private System.Windows.Forms.Button btnViDu0301;
        private System.Windows.Forms.Button btnViDu3_4;
    }
}

