using DB_NHOM7_DOANCK;
using System.Collections.Generic;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_TaoChungNhanTiemChung
    {
        public static int TaoChungNhanTiemChung(string _customerID, string _vaccineID, string _numberOfInjection)
        {
            return DB_TaoChungNhanTiemChung.TaoChungNhanTiemChung(int.Parse(_customerID) , int.Parse(_vaccineID), int.Parse(_numberOfInjection));
        }

        public static Dictionary<string, string> LoadThongTinKhachHang(string _customerID)
        {
            return DB_TaoChungNhanTiemChung.LoadThongTinKhachHang(_customerID);
        }

        public static Dictionary<string, string> LoadThongTinVaccine(string _vaccineID)
        {
            return DB_TaoChungNhanTiemChung.LoadThongTinVaccine(_vaccineID);
        }
    }
}
