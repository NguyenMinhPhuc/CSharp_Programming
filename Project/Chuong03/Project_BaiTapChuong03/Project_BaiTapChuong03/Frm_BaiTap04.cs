using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BaiTapChuong03
{
    public partial class Frm_BaiTap04 : Form
    {
        public Frm_BaiTap04 ( )
        {
            InitializeComponent();
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void btnTim_Click ( object sender, EventArgs e )
        {
           lblKetQua.Text= TimSoChinhPhuong(txtDaySo.Text);
        }

        private string TimSoChinhPhuong ( string text )
        {
            string ketQua = string.Empty;
            string[] vs = ThuVien.XuLyChuoi.XoaKhoangTrangDu(text).Split(' ');
            foreach (string item in vs)
            {
                if(LaSoChinhPhuong(item))
                {
                    ketQua += string.Format("{0}, ", item);
                }
            }
            return ketQua;
        }

        private bool LaSoChinhPhuong ( string v )
        {
            if(LaSoNguyen(v))
            {
                int number = Convert.ToInt32(v);
                int i = 0;
                while (i*i<=number)
                {
                    if (i * i == number)
                        return true;
                    ++i;
                }
            }
           
            return false;
        }

        private bool LaSoNguyen ( string v )
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(v);
        }

        private void Frm_BaiTap04_Load ( object sender, EventArgs e )
        {

        }
    }
}
