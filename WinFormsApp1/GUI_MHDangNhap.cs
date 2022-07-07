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
    public partial class GUI_MHDangNhap : Form
    {
        public GUI_MHDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_DangNhap form = new GUI_DangNhap();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_DangNhap_NV form = new GUI_DangNhap_NV();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI_DangNhap_BS form = new GUI_DangNhap_BS();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUI_DangNhap_QL form = new GUI_DangNhap_QL();
            form.Show();
        }
    }
}
