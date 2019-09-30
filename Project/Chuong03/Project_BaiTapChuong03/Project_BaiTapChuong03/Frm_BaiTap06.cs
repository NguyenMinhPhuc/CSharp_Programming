using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BaiTapChuong03
{
    public partial class Frm_BaiTap06 : Form
    {
        public Frm_BaiTap06 ( )
        {
            InitializeComponent();
        }

        private void Frm_BaiTap06_Load ( object sender, EventArgs e )
        {
            LoadDuLieuMonAn();
        }

        private void LoadDuLieuMonAn ( )
        {
            lbDanhSachMon.Items.Add("Bò kho");
            lbDanhSachMon.Items.Add("Phở bò");
            lbDanhSachMon.Items.Add("Phở gà");
            lbDanhSachMon.Items.Add("Bún năng");
            lbDanhSachMon.Items.Add("Bún bò");
            lbDanhSachMon.Items.Add("Bún riêu");
            lbDanhSachMon.Items.Add("Mì xào thập cẩm");
            lbDanhSachMon.Items.Add("Mì xào bò");
            lbDanhSachMon.Items.Add("Mì xào cay");
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void btnChonMon_Click ( object sender, EventArgs e )
        {
            string mon = string.Empty;
            if (lbDanhSachMon.SelectedItem != null)
            {
                mon = lbDanhSachMon.SelectedItem.ToString();
            }
            
            if (!string.IsNullOrEmpty(mon))
            {
                if(lbDanhSachThucDon.Items.Contains(mon))
                {
                    lbDanhSachThucDon.SelectedItem = mon;
                }
                else
                {
                    lbDanhSachThucDon.Items.Add(mon);
                    lbDanhSachMon.Items.Remove(mon);
                    if(lbDanhSachMon.Items.Count>0)
                    lbDanhSachMon.SelectedIndex = 0;
                    mon = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Chọn món");
            }
        }

        private void btnHuyMon_Click ( object sender, EventArgs e )
        {
            string mon = string.Empty;
            if (lbDanhSachThucDon.SelectedItem != null)
            {
                mon = lbDanhSachThucDon.SelectedItem.ToString();
            }

            if (!string.IsNullOrEmpty(mon))
            {
                if (lbDanhSachMon.Items.Contains(mon))
                {
                    lbDanhSachMon.SelectedItem = mon;
                }
                else
                {
                    lbDanhSachMon.Items.Add(mon);
                    lbDanhSachThucDon.Items.Remove(mon);
                    if (lbDanhSachThucDon.Items.Count > 0)
                        lbDanhSachThucDon.SelectedIndex = 0;
                    mon = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Chọn món");
            }
        }

        private void btnChonHet_Click ( object sender, EventArgs e )
        {
            for (int i = lbDanhSachMon.Items.Count-1; i >=0;  i--)
            {
                if(!lbDanhSachThucDon.Items.Contains(lbDanhSachMon.Items[i].ToString()))
                {
                    lbDanhSachThucDon.Items.Add(lbDanhSachMon.Items[i].ToString());
                    lbDanhSachMon.Items.RemoveAt(i);
                }
            }
        }

        private void btnHuyHet_Click ( object sender, EventArgs e )
        {
            for (int i = lbDanhSachThucDon.Items.Count - 1; i >= 0; i--)
            {
                if (!lbDanhSachMon.Items.Contains(lbDanhSachThucDon.Items[i].ToString()))
                {
                    lbDanhSachMon.Items.Add(lbDanhSachThucDon.Items[i].ToString());
                    lbDanhSachThucDon.Items.RemoveAt(i);
                }
            }
        }

        private void btnInThucDon_Click ( object sender, EventArgs e )
        {
            string danhsachthucdon = string.Format("Danh sách thực đơn ngày {0}\n-------------\n", DateTime.Now.ToShortDateString()) ;
            for (int i = 0; i < lbDanhSachThucDon.Items.Count; i++)
            {
                danhsachthucdon += string.Format("{0}-{1}\n", i + 1, lbDanhSachThucDon.Items[i].ToString());
            }
            MessageBox.Show(danhsachthucdon);
        }
    }
}
