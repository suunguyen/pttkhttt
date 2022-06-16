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
    public partial class GUI_HinhThucThanhToan : Form
    {
        public GUI_HinhThucThanhToan()
        {
            InitializeComponent();
        }

        private void btn_full_Click(object sender, EventArgs e)
        {
            GUI_PhuongThucThanhToan_Full form = new GUI_PhuongThucThanhToan_Full();
            form.Show();
        }

        private void btn_apart_Click(object sender, EventArgs e)
        {

        }
    }
}
