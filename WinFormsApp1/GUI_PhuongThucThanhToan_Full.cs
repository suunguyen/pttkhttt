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
    public partial class GUI_PhuongThucThanhToan_Full : Form
    {
        public GUI_PhuongThucThanhToan_Full()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_ThanhToanTienMat form = new GUI_ThanhToanTienMat();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_ThanhToanChuyenKhoan form = new GUI_ThanhToanChuyenKhoan();
            form.Show();
        }
    }
}
