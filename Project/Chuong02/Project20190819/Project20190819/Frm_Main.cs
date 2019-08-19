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
    public partial class Frm_Main : Form
    {
        public Frm_Main ( )
        {
            InitializeComponent();
        }

        private void btnViDu3_Click ( object sender, EventArgs e )
        {
            FrmViDu03_76 frmViDu03_76 = new FrmViDu03_76();
            frmViDu03_76.ShowDialog();
        }

        private void btnViDu0301_Click ( object sender, EventArgs e )
        {
            FrmViDu03_01 frmViDu03_01 = new FrmViDu03_01();
            frmViDu03_01.ShowDialog();
        }

        private void btnViDu3_4_Click ( object sender, EventArgs e )
        {
            Frm_ViDu_03_04 frm_ViDu_03_04 = new Frm_ViDu_03_04();
            frm_ViDu_03_04.ShowDialog();
        }
    }
}
