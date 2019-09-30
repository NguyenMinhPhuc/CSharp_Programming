namespace Project_Chuong04
{
    partial class Frm_ListViewChonMon
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
            this.lvMenu = new System.Windows.Forms.ListView();
            this.lvThucDon = new System.Windows.Forms.ListView();
            this.btnChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMenu
            // 
            this.lvMenu.CheckBoxes = true;
            this.lvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvMenu.FullRowSelect = true;
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(0, 0);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(541, 463);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            // 
            // lvThucDon
            // 
            this.lvThucDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvThucDon.HideSelection = false;
            this.lvThucDon.Location = new System.Drawing.Point(708, 0);
            this.lvThucDon.Name = "lvThucDon";
            this.lvThucDon.Size = new System.Drawing.Size(541, 463);
            this.lvThucDon.TabIndex = 1;
            this.lvThucDon.UseCompatibleStateImageBehavior = false;
            this.lvThucDon.View = System.Windows.Forms.View.Details;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(547, 12);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(157, 42);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // Frm_ListViewChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 463);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lvThucDon);
            this.Controls.Add(this.lvMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_ListViewChonMon";
            this.Text = "Frm_ListViewChonMon";
            this.Load += new System.EventHandler(this.Frm_ListViewChonMon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ListView lvThucDon;
        private System.Windows.Forms.Button btnChon;
    }
}