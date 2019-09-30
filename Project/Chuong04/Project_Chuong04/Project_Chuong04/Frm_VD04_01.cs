using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Chuong04
{
    public partial class Frm_VD04_01 : Form
    {
        public Frm_VD04_01 ( )
        {
            InitializeComponent();
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void btnDangNhap_Click ( object sender, EventArgs e )
        {
            progressBar1.Value = 1;
            timer1.Start();
          //  MessageBox.Show("Bạn đăng đăng nhập thành công");
        }

        private void Frm_VD04_01_Load ( object sender, EventArgs e )
        {
            ttpDangNhap.SetToolTip(txtTaiKhoan, "Nhập chuỗi ký không dấu, không khoảng trắng");

            ttpMatKhau.SetToolTip(txtMatKhau, "Nhập ít nhất 6 ký tự, nhiều nhất 10 ký tự");

            ttpDangNhap.SetToolTip(btnDangNhap, "Nhấn để đăng nhập chương trình");

            ttpDangNhap.SetToolTip(btnThoat, "Nhấn để thoát khỏi chương trình");
            helpProvider1.HelpNamespace =string.Format( @"{0}\help.html",Application.StartupPath);
            //timer1.Start();
            //this.Text = string.Format("Thời gian hiện hành {0}", DateTime.Now.ToShortTimeString());
            // timer1.Enabled = true;
        }

        private void txtTaiKhoan_TextChanged ( object sender, EventArgs e )
        {
            if(txtTaiKhoan.Text.IndexOf(' ')>0)
            {
                LoiTenDN.SetError(txtTaiKhoan, "Không được nhập khoản trắng");
            }
            else
            {
                LoiTenDN.Clear();
            }
        }

        private void txtTaiKhoan_Leave ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                LoiTenDN.SetError(txtTaiKhoan, "Tên đăng nhập không được để trống");
                lblerr.Text = "Tên đăng nhập không được để trống";
                lblerr.ForeColor = Color.Red;
            }
            else
            {
                LoiTenDN.Clear();
                lblerr.ResetText();
            }
        }

        private void timer1_Tick ( object sender, EventArgs e )
        {
           if(progressBar1.Value<progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Bạn đăng đăng nhập thành công");
               
            }
        }
    }
}
