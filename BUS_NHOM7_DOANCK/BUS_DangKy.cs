using DB_NHOM7_DOANCK;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_DangKy
    {
        public static int DangKy(string email, string username, string password)
        {
            return DB_DangKy.DangKy(email, username, password);
        }
    }
}
