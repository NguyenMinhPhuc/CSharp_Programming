using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project20190819
{
   public class MyTextBox:TextBox
    {
     
       
        protected override void OnEnter ( EventArgs e )
        {
            this.BackColor = Color.Pink;
            base.OnEnter(e);
        }
        protected override void OnLeave ( EventArgs e )
        {
            this.BackColor = Color.White;
            base.OnLeave(e);
        }
        protected override void OnKeyPress ( KeyPressEventArgs e )
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }
        protected override void OnKeyDown ( KeyEventArgs e )
        {
            
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                    //foreach (var item in form.Controls)
                    //{
                    //    if (item is TextBox)
                    //    {
                    //        if (((TextBox) item).TabIndex == this.TabIndex + 1)
                    //        {
                    //            ((TextBox) item).SelectAll();
                    //            ((TextBox) item).Focus();
                    //        }
                    //    }
                    //}
                    break;
                }
           
            base.OnKeyDown(e);
        }

        //private int TabIndexMax (int index )
        //{
        //    List<int> indexArray=new List<int>();
        //    foreach (var item in frmContainer.Controls)
        //    {
        //        if(item is TextBox)
        //        {
        //            indexArray.Add(((TextBox)item).TabIndex);
        //        }
        //    }

        //    indexArray.Sort();
        //    return indexArray[indexArray.IndexOf(index + 1)];
        //}

    }
}
