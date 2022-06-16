using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NHOM7_DOANCK
{
    public partial class GUI_ThanhToanChuyenKhoan : Form
    {
        public GUI_ThanhToanChuyenKhoan()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_checkout_Click_1(object sender, EventArgs e)
        {
            try
            {
                int customerId = Int32.Parse(tb_customerId.Text);
                int paymentId = Int32.Parse(tb_paymentId.Text);
                int total = Int32.Parse(tb_total.Text);
                int paid = Int32.Parse(tb_paid.Text);
                string dateofpayment = picker_dateofpayment.Value.ToString("yyyy-MM-dd");
                int leftAmmount = total - paid;
                if (leftAmmount == 0)
                {
                    // trả hết
                    int kq = BUS_NHOM7_DOANCK.BUS_XuLyThanhToan.XuLyThanhToan(paymentId, customerId, dateofpayment, total, paid, leftAmmount);

                    if (kq == 1)
                    {
                        MessageBox.Show("Thanh toán thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại!");
                    }
                }
                else
                {
                    // trả góp
                    int needToBePaidPerMonth = leftAmmount / 3;
                    string[] time = dateofpayment.Split("-");
                    string year = time[0];
                    string month = time[1];
                    string dd = time[2];

                    string nextMonth = (Int32.Parse(month) + 1).ToString();
                    string nextTwoMonth = (Int32.Parse(month) + 2).ToString();
                    string nextThreeMonth = (Int32.Parse(month) + 3).ToString();

                    string timeNextMonth = year + "-" + nextMonth + "-" + dd;
                    string timeNextTwoMonth = year + "-" + nextTwoMonth + "-" + dd;
                    string timeThreeTwoMonth = year + "-" + nextThreeMonth + "-" + dd;

                    // ghi vào DB
                    int kq = BUS_NHOM7_DOANCK.BUS_XuLyThanhToan.XuLyThanhToan(paymentId, customerId, dateofpayment, total, paid, leftAmmount);

                    if (kq == 1)
                    {
                        int kq_2 = BUS_NHOM7_DOANCK.BUS_XuLiTraGop.XuLiTraGop(paymentId, timeNextMonth, needToBePaidPerMonth);
                        int kq_3 = BUS_NHOM7_DOANCK.BUS_XuLiTraGop.XuLiTraGop(paymentId, timeNextTwoMonth, needToBePaidPerMonth);
                        int kq_4 = BUS_NHOM7_DOANCK.BUS_XuLiTraGop.XuLiTraGop(paymentId, timeThreeTwoMonth, needToBePaidPerMonth);

                        GUI_CacDotThanhToan form2 = new GUI_CacDotThanhToan(customerId, paid, leftAmmount, timeNextMonth, timeNextTwoMonth, timeThreeTwoMonth, needToBePaidPerMonth);
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thanh toán, vui lòng kiểm tra lại!");
            }
        }
    }
}
