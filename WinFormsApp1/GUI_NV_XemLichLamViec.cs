using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI_NHOM7_DOANCK
{
    public partial class GUI_NV_XemLichLamViec : Form
    {
        DataTable table = new DataTable();
        public GUI_NV_XemLichLamViec()
        {
            InitializeComponent();
        }

        private void BT_XemLich_Click(object sender, EventArgs e)
        {
            int StaffId = Int32.Parse(TB_MaNV.Text);
            table = BUS_XemLichLamViec.XemLichLamViec(StaffId);
            DGV_LichLamViec.DataSource = table;
        }

        private void BT_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
