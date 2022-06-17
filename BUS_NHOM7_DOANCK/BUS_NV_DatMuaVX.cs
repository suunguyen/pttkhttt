using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DB_NHOM7_DOANCK;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_NV_DatMuaVX
    {
        public static DataTable XemDSDM()
        {
            DataTable table = new DataTable();
            table = DB_NV_DatMuaVX.LoadDSDM();
            return table;
        }
        public static int XuLiSuaHD_NV(int BillID,string Status)
        {
            int kq = DB_NV_DatMuaVX.UpdateBill_NV(BillID,Status);
            return kq;
        }
        public static DataTable XemCTHD_NV(int BillID)
        {
            DataTable table = new DataTable();
            table = DB_NV_DatMuaVX.LoadCTHD_NV(BillID);
            return table;
        }
    }
}
