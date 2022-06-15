using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DB;
namespace BUS
{
    public class BUS_XemLichLamViec
    {
        public static DataTable XemLichLamViec(int StaffId)
        {
            DataTable table = new DataTable();
            table = DB_NV_XemLichLamViec.LoadLichLamViec(StaffId);
            return table;
        }
    }
}
