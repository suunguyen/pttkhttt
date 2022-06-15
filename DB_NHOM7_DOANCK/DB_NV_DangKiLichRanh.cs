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
            String str= @"Data Source=DESKTOP-RQOM2TC\DUONG;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
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
            String str = @"Data Source=DESKTOP-RQOM2TC\DUONG;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connection = new SqlConnection(str);
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
