using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_DangKy_NV
    {
        public static int DangKy(string email, string username, string password)
        {
            int rowsInserted = 0;
            DB_ConnectionString cstr = new DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                connection.Open();
                var sql = $"INSERT INTO Staffs (Email, Username, Password) " +
                            $"VALUES (@email, @username, @password)";
                var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                rowsInserted = cmd.ExecuteNonQuery();
            }
            return rowsInserted;
        }
    }
}
