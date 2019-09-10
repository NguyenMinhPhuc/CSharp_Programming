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
    public partial class Frm_CheckBoxVaRadioButton : Form
    {
        public Frm_CheckBoxVaRadioButton ( )
        {
            InitializeComponent();
        }

        private void btnThoat_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void btnLuu_Click ( object sender, EventArgs e )
        {
            string listMon;
            listMon=LayDanhSachMonHoc();
            MessageBox.Show(string.Format("{0}- {1}\n{2}", txtHovaTen.Text, txtLop.Text, listMon));
        }

        private string LayDanhSachMonHoc ( )
        {
            string listMon = "Danh sách môn: \n";
            foreach (var item in this.Controls)
            {
                if(item is CheckBox)
                {
                    if(((CheckBox)item).Checked==true)
                    {
                        listMon+=string.Format("{0}\n",((CheckBox) item).Text);
                    }
                }
            }
            return listMon;
        }
    }
}
