using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DB
{
    public class DB_NV_XemLichLamViec
    {
        public static DataTable LoadLichLamViec(int StaffId)
        {
            SqlConnection connection;
            String str = @"Data Source=DESKTOP-RQOM2TC\DUONG;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select StaffId, StartTime, EndTime from Schedules where StaffId= @StaffId", connection);    //cau truy van
            cmd.Parameters.AddWithValue("@StaffId", StaffId);
            cmd.ExecuteNonQuery();
            connection.Close();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
