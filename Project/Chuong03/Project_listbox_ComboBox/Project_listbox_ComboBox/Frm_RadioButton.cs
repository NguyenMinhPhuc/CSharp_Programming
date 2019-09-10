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
    public partial class Frm_RadioButton : Form
    {
        public Frm_RadioButton ( )
        {
            InitializeComponent();
        }
        string result = string.Empty;
        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void btnDangKy_Click ( object sender, EventArgs e )
        {
            txtNoiDung.ResetText();
            result = string.Empty;
            result += string.Format("Họ và tên: {0}\n", txtHovaTen.Text);
            result += string.Format("Khoa: {0}\n", txtKhoa.Text);
            result += string.Format("Giới tính: {0}\n", rdbNam.Checked ? "Nam" : "Nữ");

            foreach (var item in this.grpNganh.Controls)
            {
                if(item is RadioButton)
                {
                    if(((RadioButton)item).Checked==true)
                    {
                        result+= string.Format("Chuyên ngành: {0}\n", ((RadioButton)item).Text);
                    }
                }
            }
            txtNoiDung.Text = result;
        }
    }
}
