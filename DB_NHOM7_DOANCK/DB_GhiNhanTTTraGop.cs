using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_GhiNhanTTTraGop
    {
        public static int GhiNhanThongTinTraGop(int paymentId, string dateofpayment, float total)
        {
            SqlConnection connecttion;
            DB_ConnectionString cstr = new DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO PayByInstallments(PaymentId, DateOfPayment, Total) VALUES (@paymentId, @dateofpayment, @total)", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@paymentId", paymentId);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@dateofpayment", dateofpayment);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@total", total);
            int kq = cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            return kq;
        }
    }
}
