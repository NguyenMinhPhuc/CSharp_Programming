using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20190816
{
   public class CircleButton:Button
    {
        protected override void OnPaint ( PaintEventArgs pevent )
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, Width, Height);

            Region = new Region(graphicsPath);
           
            base.OnPaint(pevent);
        }
    }
}
