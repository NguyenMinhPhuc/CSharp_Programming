using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TinhToan;

namespace GiaiPhuongTrinhBacNhat
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            SoNguyen a=new SoNguyen();
            this.Text = a.CongHaiSo(4, 6).ToString();
        }
    }
}
