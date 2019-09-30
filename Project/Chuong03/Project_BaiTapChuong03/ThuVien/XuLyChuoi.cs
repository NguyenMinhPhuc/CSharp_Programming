using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThuVien
{
    public class XuLyChuoi
    {
        public static string XoaKhoangTrangDu ( string chuoi )
        {
            chuoi = chuoi.Trim();//xoa khoang trang dau va cuoi cua chuoi
            string mau = @"\s+";
            Regex myregex = new Regex(mau);
            return myregex.Replace(chuoi, " ");
        }
    }
}
