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
    public partial class GUI_ChungNhanTiemChung : Form
    {
        public string User;
        DataTable table = new DataTable();
        public GUI_ChungNhanTiemChung()
        {
            InitializeComponent();
        }

        private void button_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_ChungNhanTiemChung_Load(object sender, EventArgs e)
        {
            string CusID = User;
            table = BUS_XemCNTC.XemCNTC(CusID);
            dataGridView_CNTC.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_CNTC.CurrentRow.Index;
            textBox_SLMui.Text = dataGridView_CNTC.Rows[i].Cells[3].Value.ToString();
            textBox_HoTen.Text = dataGridView_CNTC.Rows[i].Cells[5].Value.ToString();
            textBox_CMND.Text = dataGridView_CNTC.Rows[i].Cells[6].Value.ToString();
            textBox_DiaChi.Text = dataGridView_CNTC.Rows[i].Cells[7].Value.ToString();
            textBox_Sdt.Text = dataGridView_CNTC.Rows[i].Cells[8].Value.ToString();
            textBox_NgSinh.Text = dataGridView_CNTC.Rows[i].Cells[9].Value.ToString();
            textBox_GioiTinh.Text = dataGridView_CNTC.Rows[i].Cells[10].Value.ToString();
            textBox_LoaiVaccine.Text = dataGridView_CNTC.Rows[i].Cells[14].Value.ToString();
        }
    }
}
