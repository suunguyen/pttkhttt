using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    internal class DB_GhiNhan_TTTMat
    {
        public static int GhiNhanTTThanhToanTienMat(int customerId, string dateofpayment, int paid)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=ORIENTSOFTWARE\suu.nguyen;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Payments(CustomerId, DateOfPayment, Paid) VALUES (@customerId, @dateofpayment, @paid)", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@customerId", customerId);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@dateofpayment", dateofpayment);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@paid", paid);        //dung parameter de bao mat data
            int kq = cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            return kq;
        }
    }
}
