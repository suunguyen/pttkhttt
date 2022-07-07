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
    public partial class GUI_QL_DSChucNang : Form
    {
        public string Staff;

        public void setUser(string user)
        {
            Staff = user;
        }
        public GUI_QL_DSChucNang()
        {
            InitializeComponent();
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

        private void BT_DuyetDMVX_Click(object sender, EventArgs e)
        {
            GUI_NV_DSDMVX newform = new GUI_NV_DSDMVX();
            newform.Show();
        }
    }
}
