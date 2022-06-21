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
    public partial class GUI_NV_DangKiLichRanh : Form
    {
        public string user;
        DataTable table = new DataTable();
        public GUI_NV_DangKiLichRanh()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_LichDangKi.CurrentRow.Index;
            TB_MaNV.Text = null;
            TB_ST.Text = dataGridView_LichDangKi.Rows[i].Cells[0].Value.ToString();
            TB_ET.Text = dataGridView_LichDangKi.Rows[i].Cells[1].Value.ToString();
        }
        private void BT_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_NV_DangKiLichRanh_Load(object sender, EventArgs e)
        {
            table = BUS_XuLiDangKi.XemLichDangKi();
            dataGridView_LichDangKi.DataSource = table;
        }
        private void BT_DKI_Click(object sender, EventArgs e)
        {
            int StaffId = Int32.Parse(TB_MaNV.Text);
            DateTime ST = DateTime.Parse(TB_ST.Text);
            DateTime ET = DateTime.Parse(TB_ET.Text);
            int kq = BUS_XuLiDangKi.XuliDKi(StaffId, ST, ET);
            if (kq == 0)
            {
                MessageBox.Show("Đăng kí không Thành Công!");
            }
            else
            {
                MessageBox.Show("Đăng kí thành Công");
            }
        }
    }
}