using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project20190819
{
    public partial class FrmViDu03_76 : Form
    {
        public FrmViDu03_76 ( )
        {
            InitializeComponent();
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void btnTimKiem_Click ( object sender, EventArgs e )
        {
            int i;
            i = txtNoiDung.Text.IndexOf(txtTimKiem.Text);
            if(i>=0)
            {
                txtNoiDung.SelectionStart = i;
                txtNoiDung.SelectionLength = txtTimKiem.Text.Length;              
                MessageBox.Show(txtNoiDung.SelectedText);
            }
            else
            {
                MessageBox.Show("không tìm thấy");
            }
        }
    }
}
