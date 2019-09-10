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
    public partial class FrmMain : Form
    {
        public FrmMain ( )
        {
            InitializeComponent();
        }

        private void btnViDuComboBox_Click ( object sender, EventArgs e )
        {
            Frm_ViDuComboBox frm_ViDuComboBox = new Frm_ViDuComboBox();
            frm_ViDuComboBox.ShowDialog();
        }

        private void btnViDuComboBox02_Click ( object sender, EventArgs e )
        {
            FrmViDuComboBox02 frmViDuComboBox02 = new FrmViDuComboBox02();
            frmViDuComboBox02.ShowDialog();
        }

        private void btnViDuCheckBox_Click ( object sender, EventArgs e )
        {
            Frm_CheckBoxVaRadioButton frm_CheckBoxVaRadioButton = new Frm_CheckBoxVaRadioButton();
            frm_CheckBoxVaRadioButton.ShowDialog();
        }

        private void btnNhapThongTin_Click ( object sender, EventArgs e )
        {
            Frm_CheckBoxVaRadioButton frm_CheckBoxVaRadioButton = new Frm_CheckBoxVaRadioButton();
            frm_CheckBoxVaRadioButton.ShowDialog();
        }

        private void btnNhapThongTInSinhVienrdb_Click ( object sender, EventArgs e )
        {
            Frm_RadioButton frm_RadioButton = new Frm_RadioButton();
            frm_RadioButton.ShowDialog();
        }
    }
}
