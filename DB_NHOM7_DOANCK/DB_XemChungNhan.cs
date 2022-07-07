using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_XemChungNhan
    {
        public static DataTable LoadCNTC(string CusID)
        {
            SqlConnection connecttion;
            DB_ConnectionString cstr = new DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT V.id, V.CustomerId, V.DateOfCompletion, V.NumberOfInjection, V.VaccineId, C.Name, C.IdentityNumber, C.Address, C.Phone, C.DOB, C.Gender, C.ProtectorName, C.ProtectorPhone, C.Relationship, Vc.Name FROM VaccineCertificate V, Customers C, Vaccines Vc WHERE C.Username = @CusID AND V.CustomerId = C.Id AND V.VaccineId = Vc.Id", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@CusID", CusID);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
