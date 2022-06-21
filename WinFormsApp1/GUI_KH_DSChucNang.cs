using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_NHOM7_DOANCK;

namespace GUI_NHOM7_DOANCK
{
    public partial class GUI_KH_DSChucNang : Form
    {
        public string User = "Thanh"; //t tạo cái biến này ở đây để khi m đăng nhập, m cho cái tài khoản lưu vào biên này nhe, để sau này dùng nó đi truy vấn.
        public GUI_KH_DSChucNang()
        {
            InitializeComponent();
        }

        private void button_DKTC_Click(object sender, EventArgs e)
        {
            GUI_DKTiemChung newform = new GUI_DKTiemChung();
            newform.User = User;
            newform.Show();
        }

        private void button_PhieuDKTC_Click(object sender, EventArgs e)
        {
            GUI_XemPDKTC newform = new GUI_XemPDKTC();
            newform.User = User;
            newform.Show();
        }

        private void button_ChungNhan_Click(object sender, EventArgs e)
        {
            GUI_ChungNhanTiemChung newform = new GUI_ChungNhanTiemChung();
            newform.User = User;
            newform.Show();
        }

        private void button_DatMuaVaccine_Click(object sender, EventArgs e)
        {
            string CusID = User;
            int kq = BUS_DatMuaVX.XuLiThemHD(CusID);
            GUI_KH_TaoLuuDMVX newform = new GUI_KH_TaoLuuDMVX();
            newform.User = User;
            newform.Show();
        }
    }
}
