using System;
using System.Data;
using System.Data.SqlClient;
namespace DB
{
    public class DB_NV_DangKiLichRanh
    {
        public static int InsertDKLR(int StaffID, DateTime StartTime, DateTime EndTime)
        {
            SqlConnection connection;
            DB_NHOM7_DOANCK.DB_ConnectionString cstr = new DB_NHOM7_DOANCK.DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(connect_string);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Schedules(StaffId, StartTime, EndTime) values (@a,@b,@c)", connection);
            cmd.Parameters.AddWithValue("@a", StaffID);
            cmd.Parameters.AddWithValue("@b", StartTime);
            cmd.Parameters.AddWithValue("@c", EndTime);
            int rs = cmd.ExecuteNonQuery();
            connection.Close();
            return rs;
        }
        public static DataTable LoadLichDangKi()
        {
            SqlConnection connection;
            DB_NHOM7_DOANCK.DB_ConnectionString cstr = new DB_NHOM7_DOANCK.DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connection = new SqlConnection(connect_string);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 7 StartTime,EndTime FROM Schedules", connection);    //cau truy van
            cmd.ExecuteNonQuery();
            connection.Close();  
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
