using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_NHOM7_DOANCK
{
    public class BUS_XuLiTraGop
    {
        public static int XuLiTraGop(int paymentId, string dateofpayment, float total)
        {
            int kq = DB_NHOM7_DOANCK.DB_GhiNhanTTTraGop.GhiNhanThongTinTraGop(paymentId, dateofpayment, total);
            return kq;
        }
    }
}
