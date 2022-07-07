using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_NV_CapNhapHSBA
    {
        public static int CapNhapHSBA(string ID, int CusID, string Address)
        {
            SqlConnection connecttion;
            DB_ConnectionString cstr = new DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("UPDATE MedicalRecords SET Id = @ID, Address = @Address WHERE CustomerId = @CusID", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@ID", ID);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@CusID", CusID);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@Address", Address);        //dung parameter de bao mat data
            int kq = cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            return kq;
        }
    }
}
