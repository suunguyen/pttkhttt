using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_TaoChungNhanTiemChung
    {
        public const string FIELD_CUSTOMER_NAME = "Name";
        public const string FIELD_CUSTOMER_GENDER = "Gender";
        public const string FIELD_CUSTOMER_DATEOFBIRTH = "DOB";
        public const string FIELD_CUSTOMER_ADDRESS = "Address";
        public const string FIELD_CUSTOMER_IDENTIFICATION_NUMBER = "IdentityNumber";
        public const string FIELD_CUSTOMER_PHONE_NUMBER = "Phone";
        public const string FIELD_VACCINE_ID = "Id";
        public const string FIELD_VACCINE_NAME = "Name";

        public static int TaoChungNhanTiemChung(int _customerID, int _vaccineID, int _numberOfInjection)
        {
            int rowsInserted = 0;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                connection.Open(); 
                var sql = $"INSERT INTO VaccineCertificate (CustomerID, DateOfCompletion, VaccineID, NumberOfInjection) " +
                            $"VALUES (@customerID, @dateOfCompletion, @vaccineID, @numberOfInjection)";
                var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@customerID", _customerID);
                cmd.Parameters.AddWithValue("@vaccineID", _vaccineID);
                cmd.Parameters.AddWithValue("@dateOfCompletion", DateTime.Now);
                cmd.Parameters.AddWithValue("@numberOfInjection", _numberOfInjection);
                rowsInserted = cmd.ExecuteNonQuery();
            }
            return rowsInserted;
        }

        public static Dictionary<string, string> LoadThongTinKhachHang(string _customerID)
        {
            var info = new Dictionary<string, string>();
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                connection.Open();
                var sql = "SELECT Name, Gender, DOB, Address, IdentityNumber, Phone FROM Customers WHERE Id = @customerID";
                var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@customerID", _customerID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        info.Add(FIELD_CUSTOMER_NAME, reader[FIELD_CUSTOMER_NAME].ToString());
                        info.Add(FIELD_CUSTOMER_GENDER, reader[FIELD_CUSTOMER_GENDER].ToString());
                        info.Add(FIELD_CUSTOMER_DATEOFBIRTH, reader[FIELD_CUSTOMER_DATEOFBIRTH].ToString());
                        info.Add(FIELD_CUSTOMER_ADDRESS, reader[FIELD_CUSTOMER_ADDRESS].ToString());
                        info.Add(FIELD_CUSTOMER_IDENTIFICATION_NUMBER, reader[FIELD_CUSTOMER_IDENTIFICATION_NUMBER].ToString());
                        info.Add(FIELD_CUSTOMER_PHONE_NUMBER, reader[FIELD_CUSTOMER_PHONE_NUMBER].ToString());
                    }
                }
            }
            return info;
        }

        public static Dictionary<string, string> LoadThongTinVaccine(string _vaccineID)
        {
            var info = new Dictionary<string, string>();
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                connection.Open();
                var sql = "SELECT Id, Name FROM Vaccines WHERE Id = @vaccineID";
                var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@vaccineID", _vaccineID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        info.Add(FIELD_VACCINE_ID, reader[FIELD_VACCINE_ID].ToString());
                        info.Add(FIELD_VACCINE_NAME, reader[FIELD_VACCINE_NAME].ToString());
                    }
                }
            }
            return info;
        }
    }
}
