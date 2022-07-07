using BUS_NHOM7_DOANCK;
using System;
using System.Windows.Forms;

namespace GUI_NHOM7_DOANCK
{
    public partial class GUI_DangKy : Form
    {
        public GUI_DangKy()
        {
            InitializeComponent();
        }

        private void btn_signup_click(object sender, EventArgs e)
        {
            try
            {
                BUS_DangKy.DangKy(tb_email.Text, tb_username.Text, tb_password.Text);
                MessageBox.Show("Đăng ký thành công!");
                GUI_DangNhap dn = new GUI_DangNhap();
                dn.Show();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình đăng ký, vui lòng kiểm tra lại!");
            }
        }
    }
}
