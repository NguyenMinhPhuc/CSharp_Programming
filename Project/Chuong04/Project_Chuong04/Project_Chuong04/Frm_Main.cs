using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Chuong04
{
    public partial class Frm_Main : Form
    {
        public Frm_Main ( )
        {
            InitializeComponent();
        }

        private void btnViDu04_01_Click ( object sender, EventArgs e )
        {
            Frm_VD04_01 frm_VD04_01 = new Frm_VD04_01();
            frm_VD04_01.ShowDialog();
        }

        private void btnListView_Click ( object sender, EventArgs e )
        {
            Frm_ListView frm_ListView = new Frm_ListView();
            frm_ListView.ShowDialog();
        }

        private void btnChonMon_Click ( object sender, EventArgs e )
        {
            Frm_ListViewChonMon frm_ListView = new Frm_ListViewChonMon();
            frm_ListView.ShowDialog();
        }
    }
}
