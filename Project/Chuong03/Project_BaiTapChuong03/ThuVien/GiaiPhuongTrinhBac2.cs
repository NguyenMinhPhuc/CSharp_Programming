using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
   public class GiaiPhuongTrinhBac2
    {
        public static string GiaiPhuongTrinh(int heSoA,int heSoB,int heSoC)
        {
            string nghiem = string.Empty;
            double denta, x1, x2;
            denta = Math.Pow(heSoB, 2) - 4 * heSoA * heSoC;
            if(denta==0)
            {
                x1 = x2 = -heSoB / 2.0 * heSoA;
                nghiem = string.Format("Phương trình có 1 nghiệm duy nhất là : x={0}", x1);
            }else if(denta>0)
            {
                x1 = (-heSoB + Math.Sqrt(denta)) / (2.0 * heSoA);
                x2 = (-heSoB - Math.Sqrt(denta)) / (2.0 * heSoA);
                nghiem = string.Format("Phương trình có 2 nghiệm x1={0} : x2={1}", x1,x2);
            }
            else
            {
                nghiem = "Phương trình vô nghiệm";
            }
            return nghiem;
        }
        public static string GiaiPhuongTrinh (ref double x1,ref double x2, int heSoA, int heSoB, int heSoC )
        {
            string nghiem = string.Empty;
            double denta;
            denta = Math.Pow(heSoB, 2) - 4 * heSoA * heSoC;
            if (denta == 0)
            {
                x1 = x2 = -heSoB / 2.0 * heSoA;
                nghiem = string.Format("Phương trình có 1 nghiệm duy nhất là : x={0}", x1);
            }
            else if (denta > 0)
            {
                x1 = (-heSoB + Math.Sqrt(denta)) / (2.0 * heSoA);
                x2 = (-heSoB - Math.Sqrt(denta)) / (2.0 * heSoA);
                nghiem = string.Format("Phương trình có 2 nghiệm x1={0} : x2={1}", x1, x2);
            }
            else
            {
                nghiem = "Phương trình vô nghiệm";
            }
            return nghiem;
        }
    }
}
