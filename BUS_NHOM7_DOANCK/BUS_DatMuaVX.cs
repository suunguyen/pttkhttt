using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DB_NHOM7_DOANCK;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_DatMuaVX
    {
        public static DataTable XemDSVX()
        {
            DataTable table = new DataTable();
            table = DB_DatMuaVX.LoadDSVX();
            return table;
        }
        public static int XuLiThemHD(string CusID)
        {
            int kq = DB_DatMuaVX.InsertBill(CusID);
            return kq;
        }
        public static int XuLiThemCTHD(string CusID, int VaccineID, int Quantity)
        {
            int kq = DB_DatMuaVX.InsertBillDetail(CusID, VaccineID,Quantity);
            return kq;
        }
        public static int XuLiSuaHD(string CusID)
        {
            int kq = DB_DatMuaVX.UpdateBill(CusID);
            return kq;
        }
        public static DataTable XemCTHD(string CusID)
        {
            DataTable table = new DataTable();
            table = DB_DatMuaVX.LoadBillDetail(CusID);
            return table;
        }
        public static DataTable XemTongHD(string CusID)
        {
            DataTable table = new DataTable();
            table = DB_DatMuaVX.LoadTotalBill(CusID);
            return table;
        }
    }
}
