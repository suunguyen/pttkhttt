using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_XemPhieuDKTC
    {
        public static DataTable LoadPhieuDKTC(string CusID)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers C, VaccinationRegister V WHERE C.Username = @CusID AND C.Id = V.CustomerId", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@CusID", CusID);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
