using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_DangNhap_KH
    {
        public static int DangNhapKH(string username, string password)
        {
            return DB_NHOM7_DOANCK.DB_DangNhapKH.DangNhapKH(username, password);
        }
    }
}
