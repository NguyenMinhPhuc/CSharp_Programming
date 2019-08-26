using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20190826
{
    public partial class Frm_Bai03_05 : Form
    {
        public Frm_Bai03_05 ( )
        {
            InitializeComponent();
        }

        private void txtNumber_KeyPress ( object sender, KeyPressEventArgs e )
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private int TinhTong (ref string hienThi, int n )
        {
            int Tong = 0;
            for (int i = 1; i <= n; i++)
            {
                Tong += i;
                if (i == n)
                {
                    hienThi += string.Format("{0}", i);
                }
                else
                {
                    hienThi += string.Format("{0}+", i);
                }
            }
            return Tong;
        }

        private void btnTinhTong_Click ( object sender, EventArgs e )
        {
            int number = Convert.ToInt32(txtNumber.Text);
            string hienThi = string.Empty;
            txtKetQua.Text = TinhTong(ref hienThi,number).ToString();
            txtHienThi.Text = hienThi;
        }
    }
}
