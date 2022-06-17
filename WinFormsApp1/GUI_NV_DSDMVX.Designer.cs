
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_NV_DSDMVX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DTGV_DSDM = new System.Windows.Forms.DataGridView();
            this.DTGV_CTD = new System.Windows.Forms.DataGridView();
            this.GB_TTDM = new System.Windows.Forms.GroupBox();
            this.BT_Luu = new System.Windows.Forms.Button();
            this.TB_TrangThai = new System.Windows.Forms.TextBox();
            this.LB_TrangThai = new System.Windows.Forms.Label();
            this.TB_Ngay = new System.Windows.Forms.TextBox();
            this.LB_Ngay = new System.Windows.Forms.Label();
            this.TB_TongTien = new System.Windows.Forms.TextBox();
            this.LB_TongTien = new System.Windows.Forms.Label();
            this.TB_MaKH = new System.Windows.Forms.TextBox();
            this.LB_MaKH = new System.Windows.Forms.Label();
            this.TB_MaDon = new System.Windows.Forms.TextBox();
            this.LB_MaDon = new System.Windows.Forms.Label();
            this.GB_CTD = new System.Windows.Forms.GroupBox();
            this.BT_TroLai = new System.Windows.Forms.Button();
            this.LB_DSDM = new System.Windows.Forms.Label();
            this.GB_DSDM = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DSDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CTD)).BeginInit();
            this.GB_TTDM.SuspendLayout();
            this.GB_CTD.SuspendLayout();
            this.GB_DSDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGV_DSDM
            // 
            this.DTGV_DSDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_DSDM.Location = new System.Drawing.Point(0, 15);
            this.DTGV_DSDM.Name = "DTGV_DSDM";
            this.DTGV_DSDM.RowHeadersWidth = 62;
            this.DTGV_DSDM.RowTemplate.Height = 33;
            this.DTGV_DSDM.Size = new System.Drawing.Size(1229, 388);
            this.DTGV_DSDM.TabIndex = 2;
            this.DTGV_DSDM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_DSDM_CellContentClick);
            // 
            // DTGV_CTD
            // 
            this.DTGV_CTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_CTD.Location = new System.Drawing.Point(16, 56);
            this.DTGV_CTD.Name = "DTGV_CTD";
            this.DTGV_CTD.RowHeadersWidth = 62;
            this.DTGV_CTD.RowTemplate.Height = 33;
            this.DTGV_CTD.Size = new System.Drawing.Size(594, 294);
            this.DTGV_CTD.TabIndex = 3;
            this.DTGV_CTD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GB_TTDM
            // 
            this.GB_TTDM.Controls.Add(this.BT_Luu);
            this.GB_TTDM.Controls.Add(this.TB_TrangThai);
            this.GB_TTDM.Controls.Add(this.LB_TrangThai);
            this.GB_TTDM.Controls.Add(this.TB_Ngay);
            this.GB_TTDM.Controls.Add(this.LB_Ngay);
            this.GB_TTDM.Controls.Add(this.TB_TongTien);
            this.GB_TTDM.Controls.Add(this.LB_TongTien);
            this.GB_TTDM.Controls.Add(this.TB_MaKH);
            this.GB_TTDM.Controls.Add(this.LB_MaKH);
            this.GB_TTDM.Controls.Add(this.TB_MaDon);
            this.GB_TTDM.Controls.Add(this.LB_MaDon);
            this.GB_TTDM.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GB_TTDM.Location = new System.Drawing.Point(12, 500);
            this.GB_TTDM.Name = "GB_TTDM";
            this.GB_TTDM.Size = new System.Drawing.Size(607, 368);
            this.GB_TTDM.TabIndex = 10;
            this.GB_TTDM.TabStop = false;
            this.GB_TTDM.Text = "Thông tin đặt mua";
            // 
            // BT_Luu
            // 
            this.BT_Luu.Location = new System.Drawing.Point(424, 255);
            this.BT_Luu.Name = "BT_Luu";
            this.BT_Luu.Size = new System.Drawing.Size(149, 70);
            this.BT_Luu.TabIndex = 10;
            this.BT_Luu.Text = "Lưu";
            this.BT_Luu.UseVisualStyleBackColor = true;
            this.BT_Luu.Click += new System.EventHandler(this.BT_Luu_Click);
            // 
            // TB_TrangThai
            // 
            this.TB_TrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_TrangThai.Location = new System.Drawing.Point(117, 239);
            this.TB_TrangThai.Name = "TB_TrangThai";
            this.TB_TrangThai.Size = new System.Drawing.Size(208, 39);
            this.TB_TrangThai.TabIndex = 9;
            // 
            // LB_TrangThai
            // 
            this.LB_TrangThai.AutoSize = true;
            this.LB_TrangThai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_TrangThai.Location = new System.Drawing.Point(6, 244);
            this.LB_TrangThai.Name = "LB_TrangThai";
            this.LB_TrangThai.Size = new System.Drawing.Size(108, 30);
            this.LB_TrangThai.TabIndex = 8;
            this.LB_TrangThai.Text = "Trạng thái";
            // 
            // TB_Ngay
            // 
            this.TB_Ngay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Ngay.Location = new System.Drawing.Point(437, 155);
            this.TB_Ngay.Name = "TB_Ngay";
            this.TB_Ngay.Size = new System.Drawing.Size(136, 39);
            this.TB_Ngay.TabIndex = 7;
            // 
            // LB_Ngay
            // 
            this.LB_Ngay.AutoSize = true;
            this.LB_Ngay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Ngay.Location = new System.Drawing.Point(352, 160);
            this.LB_Ngay.Name = "LB_Ngay";
            this.LB_Ngay.Size = new System.Drawing.Size(64, 30);
            this.LB_Ngay.TabIndex = 6;
            this.LB_Ngay.Text = "Ngày";
            // 
            // TB_TongTien
            // 
            this.TB_TongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_TongTien.Location = new System.Drawing.Point(117, 155);
            this.TB_TongTien.Name = "TB_TongTien";
            this.TB_TongTien.Size = new System.Drawing.Size(208, 39);
            this.TB_TongTien.TabIndex = 5;
            // 
            // LB_TongTien
            // 
            this.LB_TongTien.AutoSize = true;
            this.LB_TongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_TongTien.Location = new System.Drawing.Point(6, 160);
            this.LB_TongTien.Name = "LB_TongTien";
            this.LB_TongTien.Size = new System.Drawing.Size(105, 30);
            this.LB_TongTien.TabIndex = 4;
            this.LB_TongTien.Text = "Tổng tiền";
            // 
            // TB_MaKH
            // 
            this.TB_MaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_MaKH.Location = new System.Drawing.Point(437, 69);
            this.TB_MaKH.Name = "TB_MaKH";
            this.TB_MaKH.Size = new System.Drawing.Size(136, 39);
            this.TB_MaKH.TabIndex = 3;
            // 
            // LB_MaKH
            // 
            this.LB_MaKH.AutoSize = true;
            this.LB_MaKH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_MaKH.Location = new System.Drawing.Point(352, 74);
            this.LB_MaKH.Name = "LB_MaKH";
            this.LB_MaKH.Size = new System.Drawing.Size(79, 30);
            this.LB_MaKH.TabIndex = 2;
            this.LB_MaKH.Text = "Mã KH";
            // 
            // TB_MaDon
            // 
            this.TB_MaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_MaDon.Location = new System.Drawing.Point(117, 68);
            this.TB_MaDon.Name = "TB_MaDon";
            this.TB_MaDon.Size = new System.Drawing.Size(134, 39);
            this.TB_MaDon.TabIndex = 1;
            // 
            // LB_MaDon
            // 
            this.LB_MaDon.AutoSize = true;
            this.LB_MaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_MaDon.Location = new System.Drawing.Point(6, 73);
            this.LB_MaDon.Name = "LB_MaDon";
            this.LB_MaDon.Size = new System.Drawing.Size(90, 30);
            this.LB_MaDon.TabIndex = 0;
            this.LB_MaDon.Text = "Mã Đơn";
            // 
            // GB_CTD
            // 
            this.GB_CTD.Controls.Add(this.DTGV_CTD);
            this.GB_CTD.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GB_CTD.Location = new System.Drawing.Point(625, 500);
            this.GB_CTD.Name = "GB_CTD";
            this.GB_CTD.Size = new System.Drawing.Size(616, 368);
            this.GB_CTD.TabIndex = 11;
            this.GB_CTD.TabStop = false;
            this.GB_CTD.Text = "Chi tiết đơn";
            // 
            // BT_TroLai
            // 
            this.BT_TroLai.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_TroLai.Location = new System.Drawing.Point(535, 882);
            this.BT_TroLai.Name = "BT_TroLai";
            this.BT_TroLai.Size = new System.Drawing.Size(171, 69);
            this.BT_TroLai.TabIndex = 12;
            this.BT_TroLai.Text = "Trở lại";
            this.BT_TroLai.UseVisualStyleBackColor = true;
            this.BT_TroLai.Click += new System.EventHandler(this.BT_TroLai_Click);
            // 
            // LB_DSDM
            // 
            this.LB_DSDM.AutoSize = true;
            this.LB_DSDM.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_DSDM.Location = new System.Drawing.Point(379, 22);
            this.LB_DSDM.Name = "LB_DSDM";
            this.LB_DSDM.Size = new System.Drawing.Size(472, 65);
            this.LB_DSDM.TabIndex = 13;
            this.LB_DSDM.Text = "Danh Sách Đặt Mua";
            // 
            // GB_DSDM
            // 
            this.GB_DSDM.Controls.Add(this.DTGV_DSDM);
            this.GB_DSDM.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GB_DSDM.Location = new System.Drawing.Point(12, 85);
            this.GB_DSDM.Name = "GB_DSDM";
            this.GB_DSDM.Size = new System.Drawing.Size(1247, 409);
            this.GB_DSDM.TabIndex = 14;
            this.GB_DSDM.TabStop = false;
            // 
            // GUI_NV_DSDMVX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 963);
            this.Controls.Add(this.GB_DSDM);
            this.Controls.Add(this.LB_DSDM);
            this.Controls.Add(this.BT_TroLai);
            this.Controls.Add(this.GB_CTD);
            this.Controls.Add(this.GB_TTDM);
            this.Name = "GUI_NV_DSDMVX";
            this.Text = "GUI_NV_DSDMVX";
            this.Load += new System.EventHandler(this.GUI_NV_DSDMVX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DSDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CTD)).EndInit();
            this.GB_TTDM.ResumeLayout(false);
            this.GB_TTDM.PerformLayout();
            this.GB_CTD.ResumeLayout(false);
            this.GB_DSDM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DTGV_DSDM;
        private System.Windows.Forms.DataGridView DTGV_CTD;
        private System.Windows.Forms.GroupBox GB_TTDM;
        private System.Windows.Forms.Button BT_Luu;
        private System.Windows.Forms.TextBox TB_TrangThai;
        private System.Windows.Forms.Label LB_TrangThai;
        private System.Windows.Forms.TextBox TB_Ngay;
        private System.Windows.Forms.Label LB_Ngay;
        private System.Windows.Forms.TextBox TB_TongTien;
        private System.Windows.Forms.Label LB_TongTien;
        private System.Windows.Forms.TextBox TB_MaKH;
        private System.Windows.Forms.Label LB_MaKH;
        private System.Windows.Forms.TextBox TB_MaDon;
        private System.Windows.Forms.Label LB_MaDon;
        private System.Windows.Forms.GroupBox GB_CTD;
        private System.Windows.Forms.Button BT_TroLai;
        private System.Windows.Forms.Label LB_DSDM;
        private System.Windows.Forms.GroupBox GB_DSDM;
    }
}