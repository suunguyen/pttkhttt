using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DB_NHOM7_DOANCK;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_XemPDKTC
    {
        public static DataTable XemPDKTC(string CusID)
        {
            DataTable table = new DataTable();
            table = DB_XemPhieuDKTC.LoadPhieuDKTC(CusID);
            return table;
        }
    }
}
