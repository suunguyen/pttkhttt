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
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var kq = BUS_NHOM7_DOANCK.BUS_DangNhap_KH.DangNhapKH(tb_username.Text, tb_password.Text);
                if (kq == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác!");
                    return;
                }
                MessageBox.Show("Đăng nhập thành công!");
                GUI_KH_DSChucNang form = new GUI_KH_DSChucNang();
                form.setUser(tb_username.Text);
                form.Show();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình đăng nhập, vui lòng thử lại sau!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            GUI_DangKy form = new GUI_DangKy();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
