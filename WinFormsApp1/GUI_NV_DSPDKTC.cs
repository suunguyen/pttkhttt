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
    public partial class GUI_NV_DSPDKTC : Form
    {
        DataTable table = new DataTable();
        public GUI_NV_DSPDKTC()
        {
            InitializeComponent();
        }

        private void button_P_DongPhieu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_NV_DSPDKTC_Load(object sender, EventArgs e)
        {
            table = BUS_NV_DSPDK.XemDSPDK();
            dataGridView_DSPDK.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_DSPDK.CurrentRow.Index;
            textBox_P_HoVaTen.Text = dataGridView_DSPDK.Rows[i].Cells[5].Value.ToString();
            textBox_P_CMND.Text = dataGridView_DSPDK.Rows[i].Cells[6].Value.ToString();
            textBox_P_DiaChi.Text = dataGridView_DSPDK.Rows[i].Cells[7].Value.ToString();
            textBox_P_SDT.Text = dataGridView_DSPDK.Rows[i].Cells[8].Value.ToString();
            textBox_P_NgSinh.Text = dataGridView_DSPDK.Rows[i].Cells[9].Value.ToString();
            textBox_P_GioiTinh.Text = dataGridView_DSPDK.Rows[i].Cells[10].Value.ToString();
            textBox_P_GH_HoVaTen.Text = dataGridView_DSPDK.Rows[i].Cells[11].Value.ToString();
            textBox_P_GH_SoDT.Text = dataGridView_DSPDK.Rows[i].Cells[11].Value.ToString();
            textBox_P_NgTiem.Text = dataGridView_DSPDK.Rows[i].Cells[2].Value.ToString();
            textBox_P_MaKH.Text = dataGridView_DSPDK.Rows[i].Cells[1].Value.ToString();
        }
    }
}
