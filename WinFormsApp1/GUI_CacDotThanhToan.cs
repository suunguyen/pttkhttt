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
    public partial class GUI_CacDotThanhToan : Form
    {
        public GUI_CacDotThanhToan()
        {
            InitializeComponent();
        }

        public GUI_CacDotThanhToan(int customerId, int paid, int left, string nextDate, string nextTwoDate, string nextThreeDate, float needToPay)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.paid = paid;
            this.left = left;
            this.nextDate = nextDate;
            this.nextTwoDate = nextTwoDate;
            this.nextThreeDate = nextThreeDate;
            this.needToPay = needToPay;
        }

        public int customerId { get; set; }
        public int paid { get; set; }
        public int left { get; set; }
        public string nextDate { get; set; }
        public string nextTwoDate { get; set; }
        public string nextThreeDate { get; set; }
        public float needToPay { get; set; }
        private void GUI_CacDotThanhToan_Load(object sender, EventArgs e)
        {
            tb_customerId.Text = customerId.ToString();
            tb_paid.Text = paid.ToString() + " đ";
            tb_left.Text = left.ToString() + " đ";
            tb_nextdate.Text = nextDate;
            tb_twonextdate.Text = nextTwoDate;
            tb_threenextdate.Text = nextThreeDate;
            tb_totalnext.Text = needToPay.ToString() + " đ";
            tb_totaltwonext.Text = needToPay.ToString() + " đ";
            tb_totalthreenext.Text = needToPay.ToString() + " đ";
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
