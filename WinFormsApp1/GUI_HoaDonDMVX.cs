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
    public partial class GUI_HoaDonDMVX : Form
    {
        public string User;
        DataTable table = new DataTable();
        public GUI_HoaDonDMVX()
        {
            InitializeComponent();
        }

        private void DTGV_CTHĐ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string CusID = User;
            table = BUS_DatMuaVX.XemCTHD(CusID);
            DTGV_CTHD.DataSource = table;
        }

        private void DTGV_TotalBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string CusID = User;
            table = BUS_DatMuaVX.XemTongHD(CusID);
            DTGV_CTHD.DataSource = table;
        }

        private void BT_Trolai_Click(object sender, EventArgs e)
        {
            GUI_KH_TaoLuuDMVX newform = new GUI_KH_TaoLuuDMVX();
            newform.User = User;
            newform.Show();
        }

        private void BT_Dathang_Click(object sender, EventArgs e)
        {
            string CusID = User;
            int kq = BUS_DatMuaVX.XuLiSuaHD(CusID);
            GUI_PhuongThucThanhToan_Full newform = new GUI_PhuongThucThanhToan_Full();
            newform.Show();
        }

        private void GUI_HoaDonDMVX_Load(object sender, EventArgs e)
        {
            string CusID = User;
            table = BUS_DatMuaVX.XemCTHD(CusID);
            DTGV_CTHD.DataSource = table;
            table = BUS_DatMuaVX.XemTongHD(CusID);
            DTGV_TotalBill.DataSource = table;
        }
    }
}
