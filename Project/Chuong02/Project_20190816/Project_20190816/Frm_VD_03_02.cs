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
    public partial class Frm_VD_03_02 : Form
    {
        private int number;

        public Frm_VD_03_02 ( )
        {
            InitializeComponent();
        }
        
        private void btnHienThi_Click ( object sender, EventArgs e )
        {
            lblNoiDung.Text =string.Format("Nội dung thứ {0}: ",++number);
            lblNoiDung.ForeColor = Color.Blue;
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            this.Close();//đóng form
            //Application.Exit();//Thoát project
        }

        private void btnNumber_Click ( object sender, EventArgs e )
        {
            btnNumber.Text = string.Format("CLick {0:00}: ", ++number);
        }
    }
}
