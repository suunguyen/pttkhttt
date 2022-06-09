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
    public partial class GUI_NV_DSCNTC : Form
    {
        DataTable table = new DataTable();
        public GUI_NV_DSCNTC()
        {
            InitializeComponent();
        }

        private void button_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_NV_DSCNTC_Load(object sender, EventArgs e)
        {
            table = BUS_NV_DSCN.XemDSCN();
            dataGridView_DSCN.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_DSCN.CurrentRow.Index;
            textBox_SLMui.Text = dataGridView_DSCN.Rows[i].Cells[3].Value.ToString();
            textBox_HoTen.Text = dataGridView_DSCN.Rows[i].Cells[5].Value.ToString();
            textBox_CMND.Text = dataGridView_DSCN.Rows[i].Cells[6].Value.ToString();
            textBox_DiaChi.Text = dataGridView_DSCN.Rows[i].Cells[7].Value.ToString();
            textBox_Sdt.Text = dataGridView_DSCN.Rows[i].Cells[8].Value.ToString();
            textBox_NgSinh.Text = dataGridView_DSCN.Rows[i].Cells[9].Value.ToString();
            textBox_GioiTinh.Text = dataGridView_DSCN.Rows[i].Cells[10].Value.ToString();
        }
    }
}
