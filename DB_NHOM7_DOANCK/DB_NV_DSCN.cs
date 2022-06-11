using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_NV_DSCN
    {
        public static DataTable LoadDSCN()
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=ORIENTSOFTWARE\suu.nguyen;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM VaccineCertificate V, Customers C WHERE V.CustomerId = C.Id", connecttion);    //cau truy van
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
