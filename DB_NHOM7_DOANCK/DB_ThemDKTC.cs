using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_ThemDKTC
    {
        public static int ThemDKTC(string CusID)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO VaccinationRegister (CustomerId, DateOfVaccination, Status) VALUES ((SELECT c.Id from Customers c where c.Username = @CusID), NULL, N'Chưa Tiêm')", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@CusID", CusID);        //dung parameter de bao mat data
            int kq = cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            return kq;
        }
    }
}
