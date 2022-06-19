using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_DangKy
    {
        public static int DangKy(string email, string username, string password)
        {
            int rowsInserted = 0;
            string connect_string = @"Data Source=ORIENTSOFTWARE\suu.nguyen;Initial Catalog=Vaccination;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                connection.Open(); 
                var sql = $"INSERT INTO Customers (Email, Username, Password) " +
                            $"VALUES ('@email', '@username', '@password')";
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
