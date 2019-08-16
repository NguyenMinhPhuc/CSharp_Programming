using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTap02
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            FrmLogin frmBaiTap01 = new FrmLogin();
            frmBaiTap01.ShowDialog();
        }
    }
}
