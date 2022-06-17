using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DB_NHOM7_DOANCK;


namespace BUS_NHOM7_DOANCK
{
    public class BUS_NV_ThongKeDMVX
    {
        public static DataTable XemDSHD()
        {
            DataTable table = new DataTable();
            table = DB_NV_ThongKeDMVX.LoadDSHD();
            return table;
        }
        public static DataTable XemHDTK(int Thang, int Nam)
        {
            DataTable table = new DataTable();
            table = DB_NV_ThongKeDMVX.LoadHDTK(Thang, Nam);
            return table;
        }
        public static DataTable XemHDTK_Nam(int Nam)
        {
            DataTable table = new DataTable();
            table = DB_NV_ThongKeDMVX.LoadHDTK_Nam(Nam);
            return table;
        }
    }
}
