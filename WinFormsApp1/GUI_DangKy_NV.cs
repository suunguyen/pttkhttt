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
    public partial class GUI_DangKy_NV : Form
    {
        public GUI_DangKy_NV()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_NHOM7_DOANCK.BUS_DangKy_NV.DangKy(tb_email.Text, tb_username.Text, tb_password.Text);
                MessageBox.Show("Đăng ký thành công!");
                GUI_DangNhap_NV dn = new GUI_DangNhap_NV();
                dn.Show();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình đăng ký, vui lòng kiểm tra lại!");
            }
        }
    }
}
