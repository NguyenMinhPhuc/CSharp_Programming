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
    public partial class FrmMain : Form
    {
        public FrmMain ( )
        {
            InitializeComponent();
        }

        private void btnBai03_01_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap03_01 frm_BaiTap03_01 = new Frm_BaiTap03_01();
            frm_BaiTap03_01.ShowDialog();
        }

        private void btnBaiTap03_02_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap03_02 frm_BaiTap03_02 = new Frm_BaiTap03_02();
            frm_BaiTap03_02.ShowDialog();
        }

        private void btnBaiTap03_04_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap03_04 frm_BaiTap03_04 = new Frm_BaiTap03_04();
            frm_BaiTap03_04.ShowDialog();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            Frm_Bai03_05 frm_Bai03_05 = new Frm_Bai03_05();
            frm_Bai03_05.ShowDialog();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap03_07 frm_BaiTap03_07 = new Frm_BaiTap03_07();
            frm_BaiTap03_07.ShowDialog();
        }

        private void btnBaiTap03_08_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap03_08 frm_BaiTap03_08 = new Frm_BaiTap03_08();
            frm_BaiTap03_08.ShowDialog();
        }
    }
}
