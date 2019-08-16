using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HienThiForm
{
    public partial class Frm_GiaoDienMot : Form
    {
        public Frm_GiaoDienMot()
        {
            InitializeComponent();
            this.Click += Frm_GiaoDienMot_Click;
            
        }

        

        private void Frm_GiaoDienMot_Load(object sender, EventArgs e)
        {
            
        }

        private void Frm_GiaoDienMot_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if(KiemTraForm("Frm_GiaoDienForm02"))
            {
                ActiverForm("Frm_GiaoDienForm02");
            }
            else
            {
                Frm_GiaoDienForm02 frm2 = new Frm_GiaoDienForm02();
                frm2.MdiParent = this;
                frm2.Show();
            }
           
        }

        private bool KiemTraForm(string Name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Name))
                    return true;
            }
            return false;
        }
        private void ActiverForm(string Name)
        {
            foreach (Form item in this.MdiChildren)
            {
                if(KiemTraForm(Name))
                {
                    item.Activate();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KiemTraForm("frm_Giaodien3"))
            {
                ActiverForm("frm_Giaodien3");
            }
            else
            {
                frm_Giaodien3 frm3 = new frm_Giaodien3();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
    }
}
