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
    public partial class GUI_NV_DSChucNang : Form
    {
        public string Staff;

        public void setUser(string user)
        {
            Staff = user;
        }

        public GUI_NV_DSChucNang()
        {
            InitializeComponent();
        }

        private void button_DS_DKTC_Click(object sender, EventArgs e)
        {
            GUI_NV_DSPDKTC newform = new GUI_NV_DSPDKTC();
            newform.Show();
        }

        private void button__DS_ChungNhan_Click(object sender, EventArgs e)
        {
            GUI_NV_DSCNTC newform = new GUI_NV_DSCNTC();
            newform.Show();
        }

        private void button_TaoLuuHSBA_Click(object sender, EventArgs e)
        {
            GUI_NV_TaoLuuHSBA newform = new GUI_NV_TaoLuuHSBA();
            newform.Show();
        }

        private void button_DS_TraCuuHSBA_Click(object sender, EventArgs e)
        {
            GUI_NV_TraCuuHSBA newform = new GUI_NV_TraCuuHSBA();
            newform.Show();
        }

        private void button_DangKiLichRanh_Click(object sender, EventArgs e)
        {
            GUI_NV_DangKiLichRanh newform = new GUI_NV_DangKiLichRanh();
            newform.Show();
        }

        private void button_ThongKePhieuDatMua_Click(object sender, EventArgs e)
        {
            GUI_NV_ThongKePDM newform = new GUI_NV_ThongKePDM();
            newform.Show();
        }

        private void button_PhanCong_Click(object sender, EventArgs e)
        {
            GUI_NV_XemLichLamViec newform = new GUI_NV_XemLichLamViec();
            newform.Show();
        }

        private void button_TaoChungNhan_Click(object sender, EventArgs e)
        {
            GUI_TaoChungNhanTiemChung newform = new GUI_TaoChungNhanTiemChung();
            newform.Show();
        }

        private void BT_DuyetDMVX_Click(object sender, EventArgs e)
        {
            GUI_NV_DSDMVX newform = new GUI_NV_DSDMVX();
            newform.Show();
        }

        private void GUI_NV_DSChucNang_Load(object sender, EventArgs e)
        {

        }
    }
}
