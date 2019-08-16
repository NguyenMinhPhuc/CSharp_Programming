using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToaDo
{
    public class MyPoint
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public MyPoint(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public MyPoint(MyPoint mypoint)
        {
            this.x = mypoint.x;
            this.y = mypoint.y;
        }

        public MyPoint Cong(MyPoint point1,MyPoint point2)
        {
            return new MyPoint(point1.x + point2.x, point1.y + point2.y);
        }

        public MyPoint Tru(MyPoint point1, MyPoint point2)
        {
            return new MyPoint(point1.x - point2.x, point1.y - point2.y);
        }

    }
}
