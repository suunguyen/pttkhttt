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
    public partial class GUI_BS_DSChucNang : Form
    {

        public string Staff;

        public void setUser(string user)
        {
            Staff = user;
        }
        public GUI_BS_DSChucNang()
        {
            InitializeComponent();
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

        private void button_PhanCong_Click(object sender, EventArgs e)
        {
            GUI_NV_XemLichLamViec newform = new GUI_NV_XemLichLamViec();
            newform.Show();
        }
    }
}
