using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_DangNhap_NV
    {
        public static int DangNhapNV(string username, string password)
        {
            return DB_NHOM7_DOANCK.DB_DangNhap_NV.DangNhapNV(username, password);
        }
    }
}
