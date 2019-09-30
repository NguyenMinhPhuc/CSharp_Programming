using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Chuong04
{
    public partial class Frm_ListView : Form
    {
        public Frm_ListView ( )
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    lvDanhSachSinhVien.View = View.SmallIcon;
                    break;
                case 1:
                    lvDanhSachSinhVien.View = View.List;
                    break;
                case 2:
                    lvDanhSachSinhVien.View = View.LargeIcon;
                    break;
                case 3:
                    lvDanhSachSinhVien.View = View.Details;
                    break;
                default:
                    lvDanhSachSinhVien.View = View.List;
                    break;
            }
        }


        List<SinhVien> sinhViens;

        private void Frm_ListView_Load ( object sender, EventArgs e )
        {
            lvDanhSachSinhVien.Columns.Add("MaSV", 200, HorizontalAlignment.Center);
            lvDanhSachSinhVien.Columns.Add("Họ và tên", 300, HorizontalAlignment.Center);
            lvDanhSachSinhVien.Columns.Add("Ngày sinh", 200, HorizontalAlignment.Center);

            sinhViens = new List<SinhVien>() {
                new SinhVien() {MaSV="117000123",TenSinhVien="Nguyen Van A",NgaySinh= "20-10-2000" },
                new SinhVien() {MaSV="117000124",TenSinhVien ="Nguyen Van A",NgaySinh="20-10-2000" },
                new SinhVien() {MaSV="117000125",TenSinhVien="Nguyen Van A",NgaySinh= "20-10-2000" },
                new SinhVien() {MaSV="117000126",TenSinhVien="Nguyen Van A",NgaySinh= "20-10-2000" },
                new SinhVien() {MaSV="117000127",TenSinhVien="Nguyen Van A",NgaySinh= "20-10-2000"}
            };

            foreach (SinhVien item in sinhViens)
            {
                ThemSinhVien(item);
            }

        }
        SinhVien _SinhVien;
        private void btnThem_Click ( object sender, EventArgs e )
        {
            _SinhVien = new SinhVien();
           _SinhVien= SetSinhVienFormControl();
            ThemSinhVien(_SinhVien);
        }

        private SinhVien SetSinhVienFormControl ( )
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MaSV = txtMSSV.Text;
            sinhVien.TenSinhVien = txtTenSinhVien.Text;
            sinhVien.NgaySinh = txtNgaySinh.Text;
            return sinhVien;
        }

        private void ThemSinhVien (SinhVien sinhVien)
        {
            ListViewItem listViewItem = new ListViewItem(sinhVien.MaSV);

            ListViewItem.ListViewSubItem listViewSubItemTen = new ListViewItem.ListViewSubItem(listViewItem, sinhVien.TenSinhVien);
            ListViewItem.ListViewSubItem listViewSubItemNS = new ListViewItem.ListViewSubItem(listViewItem, sinhVien.NgaySinh);

            listViewItem.SubItems.Add(listViewSubItemTen);
            listViewItem.SubItems.Add(listViewSubItemNS);

            lvDanhSachSinhVien.Items.Add(listViewItem);
        }
    }
}
