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
    public partial class Frm_BaiTap05 : Form
    {
        public Frm_BaiTap05 ( )
        {
            InitializeComponent();
        }

        private void btnPhanTich_Click ( object sender, EventArgs e )
        {
           txtKetQua.Text= PhanTich(Convert.ToInt32(txtDaySo.Text));
        }

        private string PhanTich ( int n )
        {
            string ketqua = string.Empty;
            for (int i = 2; i <= n; i++)
            {
                for (; n%i== 0;n/=i)
                {
                    ketqua+=string.Format("{0}*", i.ToString());
                }
            }
            return ketqua.Substring(0,ketqua.LastIndexOf('*'));
        }
    }
}
