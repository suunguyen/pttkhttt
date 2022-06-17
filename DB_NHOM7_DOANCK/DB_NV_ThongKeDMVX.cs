using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_NV_ThongKeDMVX
    {
        public static DataTable LoadHDTK(int Thang, int Nam)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-QO2O9VS;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS SoLuongBill,SUM(TotalBillPrice) AS TongGiaTri FROM Bills B WHERE MONTH(B.OrderDate) = @Thang AND YEAR(B.OrderDate) = @Nam", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@Thang", Thang);
            cmd.Parameters.AddWithValue("@Nam", Nam);
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static DataTable LoadHDTK_Nam(int Nam)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-QO2O9VS;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS SoLuongBill,SUM(TotalBillPrice) AS TongGiaTri FROM Bills B WHERE YEAR(B.OrderDate) = @Nam", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@Nam", Nam);
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static DataTable LoadDSHD()
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-QO2O9VS;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bills B", connecttion);    //cau truy van
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
