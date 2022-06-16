using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_XuLyThanhToan
    {
        public static int XuLyThanhToan(int paymentId, int customerId, string dateofpayment, int total, int paid, int leftAmmount)
        {
            int kq = DB_NHOM7_DOANCK.DB_GhiNhan_ThongTinThanhToan.GhiNhanTTThanhToan(paymentId, customerId, dateofpayment, total, paid, leftAmmount);
            return kq;
        }
    }
}
