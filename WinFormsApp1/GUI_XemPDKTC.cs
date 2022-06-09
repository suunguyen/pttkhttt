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
    public partial class GUI_XemPDKTC : Form
    {
        public string User;
        DataTable table = new DataTable();
        public GUI_XemPDKTC()
        {
            InitializeComponent();
        }

        private void button_P_DongPhieu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_XemPDKTC_Load(object sender, EventArgs e)
        {
            string CusID = User;
            table = BUS_XemPDKTC.XemPDKTC(CusID);
            dataGridView_P_DKTC.DataSource = table;
        }

        private void dataGridView_P_DKTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_P_DKTC.CurrentRow.Index;
            textBox_P_HoVaTen.Text = dataGridView_P_DKTC.Rows[i].Cells[1].Value.ToString();
            textBox_P_CMND.Text = dataGridView_P_DKTC.Rows[i].Cells[2].Value.ToString();
            textBox_P_DiaChi.Text = dataGridView_P_DKTC.Rows[i].Cells[3].Value.ToString();
            textBox_P_SDT.Text = dataGridView_P_DKTC.Rows[i].Cells[4].Value.ToString();
            textBox_P_NgSinh.Text = dataGridView_P_DKTC.Rows[i].Cells[5].Value.ToString();
            textBox_P_GioiTinh.Text = dataGridView_P_DKTC.Rows[i].Cells[6].Value.ToString();
            textBox_P_GH_HoVaTen.Text = dataGridView_P_DKTC.Rows[i].Cells[7].Value.ToString();
            textBox_P_GH_SoDT.Text = dataGridView_P_DKTC.Rows[i].Cells[8].Value.ToString();
            textBox_P_NgTiem.Text = dataGridView_P_DKTC.Rows[i].Cells[15].Value.ToString();
            textBox_P_MaKH.Text = dataGridView_P_DKTC.Rows[i].Cells[0].Value.ToString();
        }
    }
}
