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
using ThuVien;

namespace Project_BaiTapChuong03
{
    public partial class Frm_BaiTap01 : Form
    {
        public Frm_BaiTap01 ( )
        {
            InitializeComponent();
        }

        private void Frm_BaiTap01_Load ( object sender, EventArgs e )
        {

        }

        private void btnDemSoTu_Click ( object sender, EventArgs e )
        {
            txtKetQua.Text=DemSoTu(txtNoiDung.Text);
        }
       
       
        private string DemSoTu ( string text )
        {
            string ketQua = string.Empty;
            string[] vs = XuLyChuoi.XoaKhoangTrangDu(text).Split(' ');
            ketQua = vs.Length.ToString();
            return ketQua;
        }

        private void btnTiepTuc_Click ( object sender, EventArgs e )
        {
            ResetControl();
        }

        private void ResetControl ( )
        {
            txtNoiDung.ResetText();
            txtKetQua.ResetText();
            txtNoiDung.Focus();
            
        }
    }
}
