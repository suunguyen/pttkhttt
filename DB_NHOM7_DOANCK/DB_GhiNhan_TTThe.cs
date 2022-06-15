using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    internal class DB_GhiNhan_TTThe
    {
        public static int GhiNhanTTThanhToanThe(int customerId, string dateofpayment, int paid, int accountNumber)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=ORIENTSOFTWARE\suu.nguyen;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Payments(CustomerId, DateOfPayment, Paid) VALUES (@customerId, @dateofpayment, @paid)", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@customerId", customerId);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@dateofpayment", dateofpayment);        //dung parameter de bao mat data
            cmd.Parameters.AddWithValue("@paid", paid);
            SqlCommand cmd2 = new SqlCommand("UPDATE Customers SET BankAccountNumber = @accountNumber", connecttion);
            cmd2.Parameters.AddWithValue("@accountNumber", accountNumber);
            cmd2.ExecuteNonQuery();
            int kq = cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            return kq;
        }
    }
}
