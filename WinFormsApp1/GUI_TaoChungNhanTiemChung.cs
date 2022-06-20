using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS_NHOM7_DOANCK;
using DB_NHOM7_DOANCK;

namespace GUI_NHOM7_DOANCK
{
    public partial class GUI_TaoChungNhanTiemChung : Form
    {
        public GUI_TaoChungNhanTiemChung()
        {
            InitializeComponent();
        }

        private void button_taoChungNhan_Click(object sender, EventArgs e)
        {
            BUS_TaoChungNhanTiemChung.TaoChungNhanTiemChung(tb_customerID.Text, tb_vaccineID.Text, tb_numberOfInjection.Text);
        }

        private void button_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_xemThongTin_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> customerInfo = BUS_TaoChungNhanTiemChung.LoadThongTinKhachHang(tb_customerID.Text);
            Dictionary<string, string> vaccineInfo = BUS_TaoChungNhanTiemChung.LoadThongTinVaccine(tb_vaccineID.Text);

            tb_hoTen.Text = customerInfo[DB_TaoChungNhanTiemChung.FIELD_CUSTOMER_NAME];
            tb_gioiTinh.Text = customerInfo[DB_TaoChungNhanTiemChung.FIELD_CUSTOMER_GENDER];
            tb_ngaySinh.Text = customerInfo[DB_TaoChungNhanTiemChung.FIELD_CUSTOMER_DATEOFBIRTH];
            tb_diaChi.Text = customerInfo[DB_TaoChungNhanTiemChung.FIELD_CUSTOMER_ADDRESS];
            tb_cmnd.Text = customerInfo[DB_TaoChungNhanTiemChung.FIELD_CUSTOMER_IDENTIFICATION_NUMBER];
            tb_sdt.Text = customerInfo[DB_TaoChungNhanTiemChung.FIELD_CUSTOMER_PHONE_NUMBER];

            tb_vaccineID.Text = vaccineInfo[DB_TaoChungNhanTiemChung.FIELD_VACCINE_ID];
            tb_tenVacXin.Text = vaccineInfo[DB_TaoChungNhanTiemChung.FIELD_VACCINE_NAME];
        }
    }
}
