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
    public partial class Frm_BaiTap03_02 : Form
    {
        public Frm_BaiTap03_02 ( )
        {
            InitializeComponent();
        }
        string[] mangChu = { "không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        private void txtNumber_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtNumber_TextChanged ( object sender, EventArgs e )
        {
            if (!string.IsNullOrEmpty(txtNumber.Text))
            {
                int number = Convert.ToInt32(txtNumber.Text);
                if (number >= 0 && number <= 9)
                {
                    txtKetQua.Text = mangChu[number];
                }
                else
                {
                    MessageBox.Show("Nhập sai giá trị");
                }
            }
            else
            {
                txtKetQua.ResetText();
            }
        }
    }
}
