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
    public partial class Frm_ListViewChonMon : Form
    {
        public Frm_ListViewChonMon ( )
        {
            InitializeComponent();
        }
        List<Mon> mons;
        private void Frm_ListViewChonMon_Load ( object sender, EventArgs e )
        {
            lvMenu.View = View.Details;
            lvMenu.Columns.Add("STT", 100, HorizontalAlignment.Center);
            lvMenu.Columns.Add("Tên món", 200, HorizontalAlignment.Left);
            lvMenu.Columns.Add("Đơn giá", 150, HorizontalAlignment.Right);

            lvThucDon.Columns.Add("STT", 100, HorizontalAlignment.Center);
            lvThucDon.Columns.Add("Tên món", 200, HorizontalAlignment.Left);
            lvThucDon.Columns.Add("Đơn giá", 150, HorizontalAlignment.Right);

            mons = new List<Mon>() {
                new Mon(){Stt="1",TenMon="Lẩu gà",DonGia=1000000},
                  new Mon(){Stt="2",TenMon="Lẩu cá",DonGia=1000000},
                    new Mon(){Stt="3",TenMon="Cánh gà",DonGia=200000},
                      new Mon(){Stt="4",TenMon="Lươn xào",DonGia=1000000},
                        new Mon(){Stt="5",TenMon="Bắp chiên",DonGia=1000000},
                          new Mon(){Stt="6",TenMon="Đầu hũ",DonGia=250000},
                            new Mon(){Stt="7",TenMon="Bia 333",DonGia=200000},
                              new Mon(){Stt="8",TenMon="Bia tiger",DonGia=400000},
                            new Mon(){Stt="9",TenMon="Rượu rắn",DonGia=500000},
                            new Mon(){Stt="10",TenMon="Rượu độc",DonGia=1000000}
            };

            ThemVaoListView(mons,lvMenu);
        }

        private void ThemVaoListView ( List<Mon> mons ,ListView listView)
        {
            foreach (var item in mons)
            {
                ThemMotMonVaoListView(item, listView);
               

            }
        }

        private void ThemMotMonVaoListView ( Mon item, ListView listView )
        {
            ListViewItem listViewItem = new ListViewItem(item.Stt);

            ListViewItem.ListViewSubItem listViewSubItemTenMon = new ListViewItem.ListViewSubItem(listViewItem, item.TenMon);
            ListViewItem.ListViewSubItem listViewSubItemDonGia = new ListViewItem.ListViewSubItem(listViewItem, string.Format("{0:#,###0}", item.DonGia));

            listViewItem.SubItems.Add(listViewSubItemTenMon);
            listViewItem.SubItems.Add(listViewSubItemDonGia);

            listView.Items.Add(listViewItem);
        }

        private void btnChon_Click ( object sender, EventArgs e )
        {
            foreach (int item in lvMenu.SelectedIndices)
            {
                MessageBox.Show(lvMenu.Items[item].ToString());
            }
           
        }
    }
}
