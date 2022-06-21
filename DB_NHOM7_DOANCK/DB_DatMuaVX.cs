using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_DatMuaVX
    {
        public static int InsertBill(string CusID)
        {
            SqlConnection connection;
            String str = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Bills(CustomerId, TotalBillPrice, OrderDate, Status) values ((SELECT c.Id from Customers c where c.Username = @CusID),0,CURRENT_TIMESTAMP,N'Chưa hoàn thành')", connection);
            cmd.Parameters.AddWithValue("@CusID", CusID);
            int rs = cmd.ExecuteNonQuery();
            connection.Close();
            return rs;
        }
        public static DataTable LoadDSVX()
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id, Name, Price FROM Vaccines V", connecttion);    //cau truy van
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static int InsertBillDetail(string CusID, int VaccineID, int Quantity)
        {
            SqlConnection connection;
            String str = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into BillDetails(BillId, VaccineId, Quantity, TotalVaccinePrice) values ((SELECT MAX(Bills.Id) FROM Bills,Customers WHERE Customers.Username = @CusID),@VaccineID,@Quantity,(SELECT Vaccines.Price*@Quantity FROM Vaccines WHERE Vaccines.Id=@VaccineID))", connection);
            cmd.Parameters.AddWithValue("@CusID", CusID);
            cmd.Parameters.AddWithValue("@VaccineID", VaccineID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            int rs = cmd.ExecuteNonQuery();
            connection.Close();
            return rs;
        }
        public static int UpdateBill(string CusID)
        {
            SqlConnection connection;
            String str = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Bills SET TotalBillPrice = (SELECT SUM(BillDetails.TotalVaccinePrice) FROM BillDetails WHERE BillDetails.BillId=(SELECT MAX(Bills.Id) FROM Bills, Customers WHERE Customers.Username=@CusID)), Status = N'Chờ duyệt' WHERE Id = (SELECT MAX(Bills.Id) FROM Bills, Customers WHERE Customers.Username=@CusID)", connection);
            cmd.Parameters.AddWithValue("@CusID", CusID);
            int rs = cmd.ExecuteNonQuery();
            connection.Close();
            return rs;
        }
        public static DataTable LoadBillDetail(string CusID)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT BD.BillId,V.Name,V.Price,BD.Quantity,BD.TotalVaccinePrice FROM BillDetails BD JOIN Vaccines V ON BD.VaccineId = V.Id WHERE BD.BillId = (SELECT MAX(Id) FROM Bills WHERE CustomerId = (SELECT Id FROM Customers WHERE Username = @CusID) )", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@CusID", CusID);
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static DataTable LoadTotalBill(string CusID)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(TotalVaccinePrice) FROM BillDetails WHERE BillId=(SELECT MAX(Id) FROM Bills WHERE CustomerId = (SELECT Id FROM Customers WHERE Username= @CusID) )", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@CusID", CusID);
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
