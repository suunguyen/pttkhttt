using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DB_NHOM7_DOANCK;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_NV_XuLiTaoLuuHSBA
    {
        public static int XuLiTaoLuuHSBA(string ID, int CusID, string Address)
        {
            int kq = DB_NV_TaoLuuHSBA.TaoLuuHSBA(ID, CusID, Address);
            return kq;
        }
    }
}
