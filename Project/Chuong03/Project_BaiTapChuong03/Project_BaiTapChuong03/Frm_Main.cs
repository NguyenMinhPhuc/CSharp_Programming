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
    public partial class Frm_Main : Form
    {
        public Frm_Main ( )
        {
            InitializeComponent();
        }

        private void btnBaiTap01_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap01 frm_BaiTap01 = new Frm_BaiTap01();
            frm_BaiTap01.ShowDialog();
        }

        private void btnBaiTap02_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap02 frm_BaiTap02 = new Frm_BaiTap02();
            frm_BaiTap02.ShowDialog();
        }

        private void btnBaiTap03_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap03 frm_BaiTap03 = new Frm_BaiTap03();
            frm_BaiTap03.ShowDialog();
        }

        private void btnBaiTap04_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap04 frm_BaiTap04 = new Frm_BaiTap04();
            frm_BaiTap04.ShowDialog();
        }

        private void btnBaiTap05_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap05 frm_BaiTap05 = new Frm_BaiTap05();
            frm_BaiTap05.ShowDialog();
        }

        private void btnBaiTap06_Click ( object sender, EventArgs e )
        {
            Frm_BaiTap06 frm_BaiTap06 = new Frm_BaiTap06();
            frm_BaiTap06.ShowDialog();
        }
    }
}
