using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_NV_TaoLuuHSBA
    {
        public static int TaoLuuHSBA(string ID, int CusID, string Address)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO MedicalRecords (CustomerId, Id, Address) VALUES (@CusID, @ID, @Address)", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@ID", ID);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@CusID", CusID);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@Address", Address);        //dung parameter de bao mat data
            int kq = cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            return kq;
        }
    }
}
