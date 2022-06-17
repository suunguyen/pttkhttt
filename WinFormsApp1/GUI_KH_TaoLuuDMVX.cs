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
    public partial class GUI_KH_TaoLuuDMVX : Form
    {
        public string User;
        DataTable table = new DataTable();
        public GUI_KH_TaoLuuDMVX()
        {
            InitializeComponent();
        }

        private void GUI_KH_TaoLuuDMVX_Load(object sender, EventArgs e)
        {
            
            table = BUS_DatMuaVX.XemDSVX();
            DTGV_DSVX.DataSource = table;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTGV_DSVX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_MaVX.ReadOnly = true;
            TB_TenVX.ReadOnly = true;
            TB_GiaVX.ReadOnly = true;
            int i;
            i = DTGV_DSVX.CurrentRow.Index;
            TB_MaVX.Text = DTGV_DSVX.Rows[i].Cells[0].Value.ToString();
            TB_TenVX.Text = DTGV_DSVX.Rows[i].Cells[1].Value.ToString();
            TB_GiaVX.Text = DTGV_DSVX.Rows[i].Cells[2].Value.ToString();
        }

        private void BT_ThemCTHD_Click(object sender, EventArgs e)
        {
            string CusID = User;
            int VaccineId = Int32.Parse(TB_MaVX.Text);
            int Quantity = Convert.ToInt32(Math.Round(Num_SoLuong.Value, 0)); ;
            if (Quantity > 0)
            {
                int kq = BUS_DatMuaVX.XuLiThemCTHD(CusID, VaccineId, Quantity);
                if (kq == 0)
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                } 
            }
        }

        private void BT_Tieptuc_Click(object sender, EventArgs e)
        {
            GUI_HoaDonDMVX newform = new GUI_HoaDonDMVX();
            newform.User = User;
            newform.Show();
        }

        private void BT_TroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_MaVX_TextChanged(object sender, EventArgs e){}
    }
}
