using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DB_NHOM7_DOANCK;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_XemCNTC
    {
        public static DataTable XemCNTC(string CusID)
        {
            DataTable table = new DataTable();
            table = DB_XemChungNhan.LoadCNTC(CusID);
            return table;
        }
    }
}
