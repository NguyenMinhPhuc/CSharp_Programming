using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;

namespace Project_BaiTapChuong03
{
    public partial class Frm_BaiTap02 : Form
    {
        public Frm_BaiTap02 ( )
        {
            InitializeComponent();
        }

        private void Frm_BaiTap02_Load ( object sender, EventArgs e )
        {
            txtNoiDung.Text = "Con kiến bò trên đĩa thị bò";
        }

        private void btnDemSoTu_Click ( object sender, EventArgs e )
        {
            HienThiKetQua(ThongKeTu(txtNoiDung.Text));
        }

        private void HienThiKetQua ( Hashtable hashtable )
        {
            foreach (string item in hashtable.Keys)
            {
                lbKetQua.Items.Add(string.Format("{0}:{1} lần", item, hashtable[item].ToString()));
            }
        }

        private Hashtable ThongKeTu ( string text )
        {
            Hashtable ketQua = new Hashtable();
            string[] vs = XuLyChuoi.XoaKhoangTrangDu(text).Split(' ');
            foreach (string item in vs)
            {
                if(ketQua.ContainsKey(item)==false)
                {
                    ketQua.Add(item, 1);
                }
                else
                {
                    ketQua[item] =(int)ketQua[item] + 1;
                }
            }
            return ketQua;
        }

        private void ResetControl ( )
        {
            txtNoiDung.ResetText();
            lbKetQua.Items.Clear();
            txtNoiDung.Focus();
        }

        private void btnTiepTuc_Click ( object sender, EventArgs e )
        {
            ResetControl();
        }
    }
}
