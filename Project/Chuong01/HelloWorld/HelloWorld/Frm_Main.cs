using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            InitLabel();
        }

     
        private void InitLabel()
        {
            Label lblHelloWorld = new Label() { 
                Name = "lblHelloWorld", 
                Text = "Hello World" ,
                Location=new Point(this.Height/2,this.Width/2),
                Width =400,
                Height=90,
                Font=new Font("Tahoma",40F)
            };

            this.Controls.Add(lblHelloWorld);
        }
    }
}
