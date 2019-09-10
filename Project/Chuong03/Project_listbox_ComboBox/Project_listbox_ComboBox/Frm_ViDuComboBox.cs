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
    public partial class Frm_ViDuComboBox : Form
    {
        public Frm_ViDuComboBox ( )
        {
            InitializeComponent();
        }
        

        private void Frm_ViDuComboBox_Load ( object sender, EventArgs e )
        {
            LoadCboMau();
        }
        List<MauSac> listMau;
        bool statusload = false;
        private void LoadCboMau ( )
        {
            listMau = new List<MauSac>();
            listMau = GetData();
            cboMau.DataSource = listMau;
            cboMau.ValueMember = "MaMau";
            cboMau.DisplayMember = "TenMau";
            cboMau.SelectedIndex = -1;
            cboMau.Text = "--- Chọn màu ---";
            statusload = true;
        }

        private List<MauSac> GetData ( )
        {
           List<MauSac> listMau = new List<MauSac>();
            listMau.Add(new MauSac() { MaMau = 0, TenMau = "Xanh Dương" });
            listMau.Add(new MauSac() { MaMau = 1, TenMau = "Đỏ" });
            listMau.Add(new MauSac() { MaMau = 2, TenMau = "Vàng" });
            listMau.Add(new MauSac() { MaMau = 3, TenMau = "Xanh Lá cây" });
            listMau.Add(new MauSac() { MaMau = 4, TenMau = "Tím" });
            return listMau;
        }

        private void btnDoiMau_Click ( object sender, EventArgs e )
        {
            cboMau.Items.RemoveAt(2);
        }

        private void DoiMau (int index )
        {
            switch (index)
            {
                case (int)Mau.XANHDUONG:
                    lblChuQuyen.ForeColor = Color.Blue;
                    break;
                case (int) Mau.DO:
                    lblChuQuyen.ForeColor = Color.Red;
                    break;
                case (int) Mau.VANG:
                    lblChuQuyen.ForeColor = Color.Yellow;
                    break;
                case (int) Mau.XANHLACAY:
                    lblChuQuyen.ForeColor = Color.Green;
                    break;
                case (int) Mau.TIM:
                    lblChuQuyen.ForeColor = Color.Purple;
                    break;
                default:
                    break;
            }
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void cboMau_SelectedIndexChanged ( object sender, EventArgs e )
        {
            if (cboMau.SelectedIndex > -1&&statusload==true)
                DoiMau((int) cboMau.SelectedValue);
        }

        private void cboMau_SelectionChangeCommitted ( object sender, EventArgs e )
        {
            if (cboMau.SelectedIndex > -1 && statusload == true)
                DoiMau((int) cboMau.SelectedValue);
        }
    }
}
