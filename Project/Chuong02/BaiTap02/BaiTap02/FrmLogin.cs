using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTap02
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        bool isMouseDown = false;
        Point startPoint;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
           // this.TransparencyKey = BackColor;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                var p1 = new Point(e.X, e.Y);
                var p2 = PointToScreen(p1);
                var p3 = new Point(p2.X - startPoint.X, p2.Y - startPoint.Y);
                this.Location = p3;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
