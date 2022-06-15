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
    public partial class GUI_NV_TraCuuHSBA : Form
    {
        DataTable table = new DataTable();
        public GUI_NV_TraCuuHSBA()
        {
            InitializeComponent();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_NV_TraCuuHSBA_Load(object sender, EventArgs e)
        {
            table = BUS_NV_XuliTraCuuHSBA.XuliTraCuuHSBA();
            dataGridVie_TraCuuHSBA.DataSource = table;
        }

        private void dataGridVie_TraCuuHSBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridVie_TraCuuHSBA.CurrentRow.Index;
            textBox_MaKH.Text = dataGridVie_TraCuuHSBA.Rows[i].Cells[0].Value.ToString();
            textBox_MaHSBA.Text = dataGridVie_TraCuuHSBA.Rows[i].Cells[1].Value.ToString();
            textBox_NoiCapHSBA.Text = dataGridVie_TraCuuHSBA.Rows[i].Cells[2].Value.ToString();
        }

        private void button_CapNhapHSBA_Click(object sender, EventArgs e)
        {
            string ID = textBox_MaHSBA.Text;
            int CusID = Int32.Parse(textBox_MaKH.Text);
            string Address = textBox_NoiCapHSBA.Text;
            int kq = BUS_NV_XuliCapNhapHSBA.XuLiCapNhapHSBA(ID, CusID, Address);
            if (kq == 0)
            {
                MessageBox.Show("Cập Nhâp Không Thành Công!");
            }
            else
            {
                MessageBox.Show("Cập Nhập Thành Công!");
            }
        }
    }
}
