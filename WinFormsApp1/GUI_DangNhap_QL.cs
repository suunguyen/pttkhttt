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
    public partial class GUI_DangNhap_QL : Form
    {
        public GUI_DangNhap_QL()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var kq = BUS_NHOM7_DOANCK.BUS_DangNhap_NV.DangNhapNV(tb_username.Text, tb_password.Text);
                if (kq == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác!");
                    return;
                }
                MessageBox.Show("Đăng nhập thành công!");
                GUI_QL_DSChucNang form = new GUI_QL_DSChucNang();
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
            GUI_DangKy_NV form = new GUI_DangKy_NV();
            form.Show();
        }
    }
}
