using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_DangKy_NV
    {
        public static int DangKy(string email, string username, string password)
        {
            return DB_NHOM7_DOANCK.DB_DangKy_NV.DangKy(email, username, password);
        }
    }
}
