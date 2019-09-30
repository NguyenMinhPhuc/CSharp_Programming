using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BaiTapChuong03
{
    public partial class Frm_BaiTap03 : Form
    {
        public Frm_BaiTap03 ( )
        {
            InitializeComponent();
        }

        private void btnGiaiPhuongTrinh_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(txtHeSoA.Text))
            {
                MessageBox.Show("Chưa nhập hệ số A");
                return;
            }
            if (string.IsNullOrEmpty(txtHeSoB.Text))
            {
                MessageBox.Show("Chưa nhập hệ số B");
                return;
            }
            if (string.IsNullOrEmpty(txtHeSoC.Text))
            {
                MessageBox.Show("Chưa nhập hệ số C");
                return;
            }
            int a =Convert.ToInt32( txtHeSoA.Text);
            int b = Convert.ToInt32(txtHeSoB.Text);
            int c = Convert.ToInt32(txtHeSoC.Text);
            lblNghiem.Text = ThuVien.GiaiPhuongTrinhBac2.GiaiPhuongTrinh(a, b, c);
        }

        private void txtHeSoA_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
