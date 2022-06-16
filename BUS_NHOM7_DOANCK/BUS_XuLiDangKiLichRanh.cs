using System;
using System.Data;
using DB;
namespace BUS
{
    public class BUS_XuLiDangKi
    {
        public static int XuliDKi(int StaffID, DateTime StartTime, DateTime EndTime)
        {
            int rs = DB_NV_DangKiLichRanh.InsertDKLR(StaffID, StartTime, EndTime);
            return rs;
        }
        public static DataTable XemLichDangKi()
        {
            DataTable table = new DataTable();
            table = DB_NV_DangKiLichRanh.LoadLichDangKi();
            return table;
        }
    }

}
