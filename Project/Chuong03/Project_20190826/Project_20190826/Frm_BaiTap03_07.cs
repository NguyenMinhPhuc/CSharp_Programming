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
    public partial class Frm_BaiTap03_07 : Form
    {
        public Frm_BaiTap03_07 ( )
        {
            InitializeComponent();
        }

        private void txtNumberN_KeyPress ( object sender, KeyPressEventArgs e )
        {

        }

        private void txtNumberX_KeyPress ( object sender, KeyPressEventArgs e )
        {

        }
        private double TinhTong ( ref string hienthi1, ref string hienthi2, ref string hienthi3,int N,float X)
        {
            double Tong = 0;
            for (int i = 1; i <=N; i++)
            {
                if(i==1)
                {
                    hienthi1 += string.Format("X+");
                    hienthi2 += string.Format("{0}+", X);
                    hienthi3 += string.Format("{0}+", Math.Pow(X, i));
                    Tong += Math.Pow(X, i);
                }else if(i==N)
                {
                    hienthi1 += string.Format("X^{0}", i);
                    hienthi2 += string.Format("{0}^{1}", X, i);
                    hienthi3 += string.Format("{0}", Math.Pow(X, i));
                    Tong += Math.Pow(X, i);
                }
                else
                {
                    hienthi1 += string.Format("X^{0}+", i);
                    hienthi2 += string.Format("{0}^{1}+", X, i);
                    hienthi3 += string.Format("{0}+", Math.Pow(X, i));
                    Tong += Math.Pow(X, i);
                }
               
            }
            return Tong;
        }
        private void btnTinhTong_Click ( object sender, EventArgs e )
        {
            int numberN = Convert.ToInt32(txtNumberN.Text);
            int numberX = Convert.ToInt32(txtNumberX.Text);
            string hienThi1 = string.Empty, hienThi2 = string.Empty, hienThi3 = string.Empty;

           double ketqua= TinhTong(ref hienThi1, ref hienThi2, ref hienThi3, numberN, numberX);

            txtHienThi01.Text = hienThi1;
            txtHienThi02.Text = hienThi2;
            txtHienThi03.Text = hienThi3;
            txtKetQua.Text = ketqua.ToString();

        }

        private void Frm_BaiTap03_07_Load ( object sender, EventArgs e )
        {

        }

        private void button1_Click ( object sender, EventArgs e )
        {
            var body = "<size=14>Size = 14<br>" +
             "<b>Bold</b> <i>Italic</i> <u>Underline</u><br>" +
             "<size=11>Size = 11<br>" +
             "<color=255, 0, 0>Sample Text</color></size>" +
             "<br><size=14><color=0, 255, 0><href=https://laptrinhvb.net>https://laptrinhvb.net</href></color></size>";
            MessageBox.Show(body, "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
