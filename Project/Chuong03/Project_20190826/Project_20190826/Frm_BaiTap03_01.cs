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
    public partial class Frm_BaiTap03_01 : Form
    {
        public Frm_BaiTap03_01 ( )
        {
            InitializeComponent();
        }

        private void btnTim_Click ( object sender, EventArgs e )
        {
            int numberA, numberB, numberC;
            numberA = Convert.ToInt32(txtA.Text);
            numberB = Convert.ToInt32(txtB.Text);
            numberC = Convert.ToInt32(txtC.Text);
            int Max = 0;
            int Min = 0;
            TimSo(ref Max, ref Min, numberA, numberB, numberC);

            txtMaxNumber.Text = Max.ToString();
            txtMinNumber.Text = Min.ToString();
        }

        private void TimSo ( ref int max, ref int min, int numberA, int numberB, int numberC )
        {
            max =min= numberA;

            if (max < numberB)
                max = numberB;

            if (max < numberC)
                max = numberC;

            if (min > numberB)
                min = numberB;

            if (min > numberC)
                min = numberC;
        }
        private int TimMax(int numberA,int numberB,int numberC)
        {
            int max = numberA;
            if (max < numberB)
                max = numberB;
             if (max < numberC)
                max = numberC;
            return max;
        }
        private int TimMin( int numberA, int numberB, int numberC )
        {
            int min = numberA;
            if (min > numberB)
                min = numberB;
           if (min > numberC)
                min = numberC;

            return min;
        }

        private void txtA_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
