using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20190816
{
    public partial class Frm_Main : Form
    {
        public Frm_Main ( )
        {
            InitializeComponent();
            this.Load += Frm_Main_Load;
           
        }
        private void Frm_Main_Load ( object sender, EventArgs e )
        {
            //GraphicsPath graphicsPath = new GraphicsPath();
            //graphicsPath.AddEllipse(0, 0, this.Width, this.Height);
             
            //this.Region = new Region(graphicsPath);
        }

        private void Frm_Main_FormClosing ( object sender, FormClosingEventArgs e )
        {
            if(MessageBox.Show("bạn có muốn tắt chương trình hay không","thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        bool status = true;
        private void Frm_Main_Click ( object sender, EventArgs e )
        {
            if (status)
            {
                BackColor = Color.Yellow;
                status = false;
            }
            else
            {
                BackColor = Color.Red;
                status = true;
            }
        }

        private void Frm_Main_DoubleClick ( object sender, EventArgs e )
        {
            if (status)
            {
                BackColor = Color.Aqua;
                status = false;
            }
            else
            {
                BackColor = Color.Blue;
                status = true;
            }
        }

        private void btnViDu_03_01_Click ( object sender, EventArgs e )
        {
            FrmVD_03_01 frmVD_03_01 = new FrmVD_03_01();
            frmVD_03_01.ShowDialog();
        }

        private void btnFunc03_012_Click ( object sender, EventArgs e )
        {
            Frm_VD_03_012 frm_VD_03_012 = new Frm_VD_03_012();
            frm_VD_03_012.ShowDialog();
        }

        private void btnFunc_03_02_Click ( object sender, EventArgs e )
        {
            Frm_VD_03_02 frm_VD_03_02 = new Frm_VD_03_02();
            frm_VD_03_02.ShowDialog();
        }

        private void Frm_Main_Load_1 ( object sender, EventArgs e )
        {

        }
    }
}
