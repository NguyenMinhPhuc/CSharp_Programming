using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project20190819
{
    public partial class Frm_ViDu_03_04 : Form
    {
        public Frm_ViDu_03_04 ( )
        {
            InitializeComponent();
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void btnHienThi_Click ( object sender, EventArgs e )
        {
            string str = string.Empty;
            foreach (var item in lsbNoiDung.SelectedItems)
            {
                str +=string.Format("{0}\n", item);
            }
            MessageBox.Show(str);
        }

        private void btnThem_Click ( object sender, EventArgs e )
        {
            if(listTen.Contains(txtThem.Text))
            {
                lsbNoiDung.ClearSelected();
                lsbNoiDung.SelectedIndex = listTen.IndexOf(txtThem.Text);
            }
            else
            {
                listTen.Add(txtThem.Text);
                lsbNoiDung.DataSource = listTen;
            }
            
        }
        BindingList<string> listTen;
        private void Frm_ViDu_03_04_Load ( object sender, EventArgs e )
        {
            listTen = new BindingList<string>();
            listTen.Add("Nguyễn Van A");
            listTen.Add("Nguyễn Van B");
            listTen.Add("Nguyễn Van C");
            listTen.Add("Nguyễn Van D");
            listTen.Add("Nguyễn Van E");

            lsbNoiDung.DataSource = listTen;
        }

        private void btnXoa_Click ( object sender, EventArgs e )
        {
            //Xóa theo nội dung
            // lsbNoiDung.Items.Remove(lsbNoiDung.SelectedItem);
            //Xóa theo index (vị trí
            //  lsbNoiDung.Items.RemoveAt(lsbNoiDung.SelectedIndex);
            //Cach xóa dữ liệu từ datasource
            listTen.Remove(lsbNoiDung.SelectedItem.ToString());
            lsbNoiDung.DataSource = listTen;
        }
    }
}
