using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB_NHOM7_DOANCK
{
    public class DB_NV_DatMuaVX
    { 
        public static DataTable LoadDSDM()
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bills", connecttion);    //cau truy van
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static int UpdateBill_NV(int BillID, string Status)
        {
            SqlConnection connection;
            String str = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Bills SET Status = @Status WHERE Bills.Id = @BillID", connection);
            cmd.Parameters.AddWithValue("@BillID", BillID);
            cmd.Parameters.AddWithValue("@Status", Status);
            int rs = cmd.ExecuteNonQuery();
            connection.Close();
            return rs;
        }
        public static DataTable LoadCTHD_NV(int BillID)
        {
            SqlConnection connecttion;
            string connect_string = @"Data Source=DESKTOP-H0S6L5T\THANH;Initial Catalog=Vaccination;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT V.Name,V.Price,BD.Quantity,BD.TotalVaccinePrice FROM BillDetails BD JOIN Vaccines V ON BD.VaccineId=V.Id WHERE BillId = @BillID", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@BillID", BillID);
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
