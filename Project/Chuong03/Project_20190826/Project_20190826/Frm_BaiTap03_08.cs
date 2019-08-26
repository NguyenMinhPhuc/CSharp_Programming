using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20190826
{
    public partial class Frm_BaiTap03_08 : Form
    {
        public Frm_BaiTap03_08 ( )
        {
            InitializeComponent();
        }
        double number01 = 0;
        double number02 = 0;
        string phepTinh = string.Empty;

        string strnumber01 = string.Empty;
        string strnumber02 = string.Empty;



        private void Frm_BaiTap03_08_Load ( object sender, EventArgs e )
        {

        }
        private void ResertControl()
        {
            txtKetQua.ResetText();

            number01 = 0;
            number02 = 0;

            phepTinh = string.Empty;
            strnumber01 = string.Empty;
            strnumber02 = string.Empty;
        }
        private void btnLamLai_Click ( object sender, EventArgs e )
        {
            ResertControl();
        }

        private void btn1_Click ( object sender, EventArgs e )
        {
            if(string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}",btn1.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02+= string.Format("{0}", btn1.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn2_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn2.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn2.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn3_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn3.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn3.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn4_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn4.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn4.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn5_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn5.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn5.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn6_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn6.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn6.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn7_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn7.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn7.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn8_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn8.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn8.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn9_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn9.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn9.Text);
                txtKetQua.Text = strnumber02;
            }
        }

        private void btn0_Click ( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(phepTinh))
            {
                strnumber01 += string.Format("{0}", btn0.Text);
                txtKetQua.Text = strnumber01;
            }
            else
            {
                strnumber02 += string.Format("{0}", btn0.Text);
                txtKetQua.Text = strnumber02;
            }
        }
        bool statusCong = false;
        private void btnSoAm_Click ( object sender, EventArgs e )
        {
            if (statusCong == false)
            {
                if (string.IsNullOrEmpty(phepTinh))
                {
                    strnumber01 = string.Format("{0}", btnSoAm.Text) + strnumber01;
                    txtKetQua.Text = strnumber01;
                }
                else
                {
                    strnumber02 = string.Format("{0}", btnSoAm.Text) + strnumber02;
                    txtKetQua.Text = strnumber02;
                }
                btnSoAm.Text = "+";
                statusCong = true;
            }
            else
            {
                if (string.IsNullOrEmpty(phepTinh))
                {
                    strnumber01 = strnumber01.Substring(strnumber01.IndexOf("-") + 1);
                    txtKetQua.Text = strnumber01;
                }
                else
                {
                    strnumber02 = strnumber02.Substring(strnumber02.IndexOf("-") + 1);
                    txtKetQua.Text = strnumber02;
                }
                btnSoAm.Text = "-";
                statusCong = false;
            }
        }

        private void btnCong_Click ( object sender, EventArgs e )
        {
            phepTinh = btnCong.Text;
        }

        private void btnTru_Click ( object sender, EventArgs e )
        {
            phepTinh = btnTru.Text;
        }

        private void btnNhan_Click ( object sender, EventArgs e )
        {
            phepTinh = btnNhan.Text;
        }

        private void btnChia_Click ( object sender, EventArgs e )
        {
            phepTinh = btnChia.Text;
        }

        private void btnBang_Click ( object sender, EventArgs e )
        {
            if(!string.IsNullOrEmpty(strnumber01))
            {
                if (!string.IsNullOrEmpty(phepTinh))
                {
                    if (!string.IsNullOrEmpty(strnumber02))
                    {
                        number01 = Convert.ToDouble(strnumber01);
                        number02 = Convert.ToDouble(strnumber02);
                        switch (phepTinh)
                        {
                            case "+":
                                txtKetQua.Text =string.Format("{0}",number01 + number02);
                                break;
                            case "-":
                                txtKetQua.Text = string.Format("{0}", number01 - number02);
                                break;
                            case "*":
                                txtKetQua.Text = string.Format("{0}", number01 * number02);
                                break;
                            case "/":
                                txtKetQua.Text = string.Format("{0}", number01 / number02);
                                break;
                            default:
                                break;
                        }
                    }
                }
               
            }
        }
    }
}
