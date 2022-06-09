using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DB_NHOM7_DOANCK;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_XuLiDangKiTiemChung
    {
        public static int XuLiDKTC(string CusID)
        {
            int kq = DB_ThemDKTC.ThemDKTC(CusID);
            return kq;
        }
    }
}