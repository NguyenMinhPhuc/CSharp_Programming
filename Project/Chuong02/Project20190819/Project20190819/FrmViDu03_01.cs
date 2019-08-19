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

namespace Project20190819
{
    public partial class FrmViDu03_01 : Form
    {
        public FrmViDu03_01 ( )
        {
            InitializeComponent();
            
        }
        private bool IsNumber(string value)
        {
            foreach (char item in value)
            {
                if (!char.IsDigit(item))
                    return false;
            }
            return true;
        }
        private bool IsNumberTwo(string value)
        {
            string patter = @"^[-+]?[0-9]*\.?[0-9]+$";
            Regex regex = new Regex(patter);
            return regex.IsMatch(value);
        }
        private void btnTinh_Click ( object sender, EventArgs e )
        {
            //if(string.IsNullOrEmpty(txtNumber01.Text))
            //{
            //    MessageBox.Show("Chưa nhập giá trị Number 01");
            //    txtNumber01.Focus();
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtNumber02.Text))
            //{
            //    MessageBox.Show("Chưa nhập giá trị Number 02");
            //    txtNumber02.Focus();
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtPhepToan.Text))
            //{
            //    MessageBox.Show("Chưa nhập phép toán");
            //    txtPhepToan.Focus();
            //    return;
            //}
            string phepTinh = txtPhepToan.Text;
            int Number01= Convert.ToInt32(txtNumber01.Text); ;
            int Number02= Convert.ToInt32(txtNumber02.Text); ;
            switch (phepTinh)
            {
                case "+":
                    lblResult.Text =string.Format("Kết quả: {0}",Number01+Number02);
                    break;
                case "-":
                    lblResult.Text = string.Format("Kết quả:{0}", Number01 - Number02);
                    break;
                case "*":
                    lblResult.Text = string.Format("Kết quả:{0}", Number01 * Number02);
                    break;
                case "/":
                    lblResult.Text = string.Format("Kết quả:{0}", Number01 / Number02);
                    break;
                case "%":
                    lblResult.Text = string.Format("Kết quả:{0}", Number01 % Number02);
                    break;
                default:
                    break;
            }
        }

        private void txtNumber01_TextChanged ( object sender, EventArgs e )
        {
            if(!IsNumber(txtNumber01.Text))
            {
                MessageBox.Show("Giá trị vừa nhập không phải là số");
                txtNumber01.ResetText();
                txtNumber01.Focus();
            }
        }

        private void txtNumber02_TextChanged ( object sender, EventArgs e )
        {
            if (!IsNumberTwo(txtNumber02.Text))
            {
                MessageBox.Show("Giá trị vừa nhập không phải là số");
                txtNumber02.ResetText();
                txtNumber02.Focus();
            }
        }

        private void txtPhepToan_TextChanged ( object sender, EventArgs e )
        {
            if (txtPhepToan.Text.Length >= 1)
            {
                if (!KiemTraPhepTinh(txtPhepToan.Text))
                {
                    MessageBox.Show("Giá trị nhập không phải phép tính");
                    txtPhepToan.ResetText();
                    txtPhepToan.Focus();
                }
            }
        }

        private bool KiemTraPhepTinh ( string text )
        {
            if(text.Length==1)
            {
                switch (text)
                {
                    case "+":
                        return true;
                    case "-":
                        return true;
                    case "*":
                        return true;
                    case "/":
                        return true;
                    case "%":
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void FrmViDu03_01_Load ( object sender, EventArgs e )
        {

        }

        private void txtNumber01_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumber02_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumber01_KeyDown ( object sender, KeyEventArgs e )
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtNumber02.SelectAll();
                    txtNumber02.Focus();
                    break;
            }
        }

        private void txtNumber02_KeyDown ( object sender, KeyEventArgs e )
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtPhepToan.SelectAll();
                    txtPhepToan.Focus();
                    break;
            }
        }

        private void txtPhepToan_KeyDown ( object sender, KeyEventArgs e )
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnTinh.PerformClick();
                    break;
            }
        }

        private void txtNumber01_Enter ( object sender, EventArgs e )
        {
            txtNumber01.BackColor = Color.Pink;
        }

        private void txtNumber01_Leave ( object sender, EventArgs e )
        {
            txtNumber01.BackColor = Color.White;
        }

        private void txtNumber02_Enter ( object sender, EventArgs e )
        {
            txtNumber02.BackColor = Color.Pink;
        }

        private void txtNumber02_Leave ( object sender, EventArgs e )
        {
            txtNumber02.BackColor = Color.White;
        }

        private void txtPhepToan_Enter ( object sender, EventArgs e )
        {
            txtPhepToan.BackColor = Color.Pink;
        }

        private void txtPhepToan_Leave ( object sender, EventArgs e )
        {
            txtPhepToan.BackColor = Color.White;
        }
    }
}
