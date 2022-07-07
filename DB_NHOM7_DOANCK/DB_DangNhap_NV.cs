using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_DangNhap_NV
    {
        public static int DangNhapNV(string username, string password)
        {
            DB_ConnectionString cstr = new DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                connection.Open();
                var sql = $"SELECT * FROM Staffs WHERE Username=@username AND Password=@password";
                var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int query = cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                bool isNotEmpty = reader.Read();
                if (isNotEmpty)
                {
                    return 1;
                }
                connection.Close();
            }

            return 0;
        }
    }
}
