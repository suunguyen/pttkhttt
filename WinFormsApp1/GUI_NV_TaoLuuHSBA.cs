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
    public partial class GUI_NV_TaoLuuHSBA : Form
    {
        public GUI_NV_TaoLuuHSBA()
        {
            InitializeComponent();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_TaoHSBA_Click(object sender, EventArgs e)
        {
            int CusID = Int32.Parse(textBox_MaKH.Text);
            string ID = textBox_MaHSBA.Text;
            string Address = textBox_NoiCapHSBA.Text;
            int kq = BUS_NV_XuLiTaoLuuHSBA.XuLiTaoLuuHSBA(ID, CusID, Address);
            if (kq == 0)
            {
                MessageBox.Show("Tạo HSBA Không Thành Công!");
            }
            else
            {
                MessageBox.Show("Tạo HSBA Thành Công1");
            }
        }
    }
}
