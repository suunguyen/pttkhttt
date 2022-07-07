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
            DB_NHOM7_DOANCK.DB_ConnectionString cstr = new DB_NHOM7_DOANCK.DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connection = new SqlConnection(connect_string);
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
