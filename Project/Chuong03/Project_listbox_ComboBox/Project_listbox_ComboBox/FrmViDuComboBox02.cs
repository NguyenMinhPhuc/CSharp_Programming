using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_listbox_ComboBox
{
    public partial class FrmViDuComboBox02 : Form
    {
        public FrmViDuComboBox02 ( )
        {
            InitializeComponent();
        }

        private void btnThem_Click ( object sender, EventArgs e )
        {
            ThemSanPham(txtTenSanPham.Text.Trim());
        }

        private void ThemSanPham ( string text )
        {
            if (lsbSanPham.Items.Contains(text))
            {
                lsbSanPham.SelectedItem = text;
            }
            else
            {
                lsbSanPham.Items.Add(text);
                XacDinhGiaTriChoCbo();
                txtTenSanPham.ResetText();
                txtTenSanPham.Focus();
            }
        }

        private void FrmViDuComboBox02_Load ( object sender, EventArgs e )
        {
            XacDinhGiaTriChoCbo();
        }

        private void XacDinhGiaTriChoCbo ( )
        {
            cboViTri.Items.Clear();
            int soPhanTu = lsbSanPham.Items.Count;
            for (int i = 0; i < soPhanTu; i++)
            {
                cboViTri.Items.Add(i.ToString());
            }
        }

        private void btnThemViTri_Click ( object sender, EventArgs e )
        {
            if(!string.IsNullOrEmpty(txtTenSanPhamCbo.Text))
            {
                if(cboViTri.SelectedIndex>-1)
                {
                    InsertValueToList(Convert.ToInt32(cboViTri.Text), txtTenSanPhamCbo.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Chưa chọn vị trí");
                    cboViTri.Focus();
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập trên san phẩm");
                txtTenSanPhamCbo.Focus();
            }
        }

        private void InsertValueToList ( int index, string value )
        {
            if (lsbSanPham.Items.Contains(value))
            {
                lsbSanPham.SelectedItem = value;
            }
            else
            {
                lsbSanPham.Items.Insert(index, value);
                XacDinhGiaTriChoCbo();
                txtTenSanPhamCbo.ResetText();
                txtTenSanPhamCbo.Focus();
            }
        }

        private void btnTimKiem_Click ( object sender, EventArgs e )
        {
            TimKiem(txtTim.Text.Trim());
        }

        private void TimKiem ( string text )
        {
            if(!string.IsNullOrEmpty(text))
            {
                if(lsbSanPham.Items.Contains(text))
                {
                    MessageBox.Show("Có giá trị cần tìm");
                    lsbSanPham.SelectedItem = text;
                }
                else
                {
                    MessageBox.Show("Không có giá trị cần tìm");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập giá trị tìm");
            }
        }

        private void btnXoaSanPham_Click ( object sender, EventArgs e )
        {
            int index = lsbSanPham.SelectedIndex;
            if(index>=0)
            {
                lsbSanPham.Items.RemoveAt(index);
                index = -1;
                XacDinhGiaTriChoCbo();
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm");
            }
        }

        private void btnXoaDanhSachSanPham_Click ( object sender, EventArgs e )
        {
            lsbSanPham.Items.Clear();
            XacDinhGiaTriChoCbo();
        }

        private void btnThemDuLieu_Click ( object sender, EventArgs e )
        {
            lsbSanPham.Items.Clear();
            lsbSanPham.Items.Add("Máy tính Dell");
            lsbSanPham.Items.Add("Máy tính Asus");
            lsbSanPham.Items.Add("Máy tính HP");
            lsbSanPham.Items.Add("Máy tính Lenovo");
            lsbSanPham.Items.Add("Máy tính Mac");
            lsbSanPham.Items.Add("Máy tính Acer");
            lsbSanPham.Items.Add("Máy tính Sony");
            XacDinhGiaTriChoCbo();
        }
    }
}
