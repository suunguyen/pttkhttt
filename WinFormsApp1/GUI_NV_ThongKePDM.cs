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
    public partial class GUI_NV_ThongKePDM : Form
    {
        DataTable table = new DataTable();
        public GUI_NV_ThongKePDM()
        {
            InitializeComponent();
        }

        private void DTGV_DSDM_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void BT_Luu_Click(object sender, EventArgs e){}

        private void BT_TK_Click(object sender, EventArgs e)
        {
            int Nam = Convert.ToInt32(Math.Round(Num_Nam.Value, 0)); ;
            if (CbB_Thang.Text != "ALL")
            {
                int Thang = Int32.Parse(CbB_Thang.Text);
                table = BUS_NV_ThongKeDMVX.XemHDTK(Thang, Nam);
                DTGV_TK.DataSource = table;
            }
            else
            {
                table = BUS_NV_ThongKeDMVX.XemHDTK_Nam(Nam);
                DTGV_TK.DataSource = table;
            }
        }

        private void BT_Trolai_Click(object sender, EventArgs e)
        {
            
        }


        private void BT_Trolai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_NV_ThongKePDM_Load(object sender, EventArgs e)
        {
            table = BUS_NV_DatMuaVX.XemDSDM();
            DTGV_DSDM.DataSource = table;
        }
    }
}
