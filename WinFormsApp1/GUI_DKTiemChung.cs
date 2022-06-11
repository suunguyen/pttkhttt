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
    public partial class GUI_DKTiemChung : Form
    {
        public string User;
        public GUI_DKTiemChung()
        {
            InitializeComponent();
        }

        private void button_DangKi_Click(object sender, EventArgs e)
        {
            string CusID = User;
            int kq = BUS_XuLiDangKiTiemChung.XuLiDKTC(CusID);
            if (kq == 0)
            {
                MessageBox.Show("Đăng Kí Không Thành Công!");
            }    
            else
            {
                MessageBox.Show("Đăng Kí Thành Công1");
            }    
        }

        private void button_HuyDK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 