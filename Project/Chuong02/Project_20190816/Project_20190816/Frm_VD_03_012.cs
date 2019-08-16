using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20190816
{
    public partial class Frm_VD_03_012 : Form
    {
        public Frm_VD_03_012 ( )
        {
            InitializeComponent();
        }

        private void Frm_VD_03_012_Load ( object sender, EventArgs e )
        {
            Label lbltitle = new Label();

            lbltitle.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
            lbltitle.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            lbltitle.ForeColor = Color.Red;
            lbltitle.AutoSize = false;
            lbltitle.Size = new Size(this.Width-50, 50);
            lbltitle.Location=new Point(20, 40);
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(lbltitle);

            Label lblThongTin;
            int BeginY = lbltitle.Location.Y + 100;
            for (int i = 0; i < 5; i++)
            {
                lblThongTin = new Label();

                lblThongTin.Font = new Font("Tahoma", 18, FontStyle.Underline);
                lblThongTin.Name = string.Format("lblThongTin{0:00}", i + 1);
                
                lblThongTin.Location = new Point(lbltitle.Location.X + 100, BeginY+40);
                BeginY = lblThongTin.Location.Y;
                lblThongTin.AutoSize = true;

                switch (lblThongTin.Name)
                {
                    case "lblThongTin01":
                        lblThongTin.Text = "Mã sinh viên :117000123";
                        break;
                    case "lblThongTin02":
                        lblThongTin.Text = "Họ và tên: Nguyễn Minh Phúc";
                        break;
                    case "lblThongTin03":
                        lblThongTin.Text = "Lớp: 17SE111";
                        break;
                    case "lblThongTin04":
                        lblThongTin.Text = "Email: phuc@lhu.edu.vn";
                        break;
                    case "lblThongTin05":
                        lblThongTin.Text = "Điện thoại: 019292938";
                        break;
                }
                this.Controls.Add(lblThongTin);
            }

        }
    }
}
