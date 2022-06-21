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
    public partial class GUI_NV_DSDMVX : Form
    {
        DataTable table = new DataTable();
        public GUI_NV_DSDMVX()
        {
            InitializeComponent();
        }

       

        private void GB_TTDM_Enter(object sender, EventArgs e){ }

        private void DTGV_DSDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_MaDon.ReadOnly = true;
            TB_MaKH.ReadOnly = true;
            TB_TongTien.ReadOnly = true;
            TB_Ngay.ReadOnly = true;
            int i;
            i = DTGV_DSDM.CurrentRow.Index;
            TB_MaDon.Text = DTGV_DSDM.Rows[i].Cells[0].Value.ToString();
            TB_MaKH.Text = DTGV_DSDM.Rows[i].Cells[1].Value.ToString();
            TB_TongTien.Text = DTGV_DSDM.Rows[i].Cells[2].Value.ToString();
            TB_Ngay.Text = DTGV_DSDM.Rows[i].Cells[3].Value.ToString();
            TB_TrangThai.Text = DTGV_DSDM.Rows[i].Cells[4].Value.ToString();
            int BillID = Int32.Parse(TB_MaDon.Text);
            table = BUS_NV_DatMuaVX.XemCTHD_NV(BillID);
            DTGV_CTD.DataSource = table;
        }

        private void groupBox1_Enter(object sender, EventArgs e){ }

        //private void LB_DSDM_Click(object sender, EventArgs e){ }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            int BillID = Int32.Parse(TB_MaDon.Text);
            string Status = TB_TrangThai.Text;
            int kq = BUS_NV_DatMuaVX.XuLiSuaHD_NV(BillID, Status);
            if (kq == 0)
            {
                MessageBox.Show("Lưu không thành công!");
            }
            else
            {
                MessageBox.Show("Lưu thành công");

            }
            table = BUS_NV_DatMuaVX.XemDSDM();
            DTGV_DSDM.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        //private void button1_Click(object sender, EventArgs e){this.Close();}

        private void BT_TroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_NV_DSDMVX_Load(object sender, EventArgs e)
        {
            table = BUS_NV_DatMuaVX.XemDSDM();
            DTGV_DSDM.DataSource = table;
        }
    }
}
