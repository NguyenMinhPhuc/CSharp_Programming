using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinhToan
{
    public class SoNguyen
    {
        private int value;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public int CongHaiSo(int value1,int value2)
        {
            return value1 + value2;
        }

    }
}
