using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_GhiNhan_ThongTinThanhToan
    {
        public static int GhiNhanTTThanhToan(int paymentId, int customerId, string dateofpayment, int total, int paid, int leftAmmount)
        {
            SqlConnection connecttion;
            DB_ConnectionString cstr = new DB_ConnectionString();
            string connect_string = cstr.getConnectionString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Payments(CustomerId, DateOfPayment, Total, Paid, LeftAmount) VALUES (@customerId, @dateofpayment, @total, @paid, @leftAmmount)", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@paymentId", paymentId);
            cmd.Parameters.AddWithValue("@customerId", customerId);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@dateofpayment", dateofpayment);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@paid", paid);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@leftAmmount", leftAmmount);
            int kq = cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            return kq;
        }
    }
}
