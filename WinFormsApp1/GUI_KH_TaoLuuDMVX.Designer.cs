
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_KH_TaoLuuDMVX
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
            this.DTGV_DSVX = new System.Windows.Forms.DataGridView();
            this.LB_DMVX = new System.Windows.Forms.Label();
            this.GB_ThongTinVX = new System.Windows.Forms.GroupBox();
            this.LB_MaVX = new System.Windows.Forms.Label();
            this.LB_TenVX = new System.Windows.Forms.Label();
            this.LB_GiaVX = new System.Windows.Forms.Label();
            this.LB_SoLuong = new System.Windows.Forms.Label();
            this.TB_MaVX = new System.Windows.Forms.TextBox();
            this.TB_TenVX = new System.Windows.Forms.TextBox();
            this.TB_GiaVX = new System.Windows.Forms.TextBox();
            this.Num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.BT_ThemCTHD = new System.Windows.Forms.Button();
            this.BT_TroLai = new System.Windows.Forms.Button();
            this.BT_Tieptuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DSVX)).BeginInit();
            this.GB_ThongTinVX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV_DSVX
            // 
            this.DTGV_DSVX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_DSVX.Location = new System.Drawing.Point(31, 128);
            this.DTGV_DSVX.Name = "DTGV_DSVX";
            this.DTGV_DSVX.RowHeadersWidth = 62;
            this.DTGV_DSVX.RowTemplate.Height = 33;
            this.DTGV_DSVX.Size = new System.Drawing.Size(1173, 412);
            this.DTGV_DSVX.TabIndex = 0;
            this.DTGV_DSVX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_DSVX_CellContentClick);
            // 
            // LB_DMVX
            // 
            this.LB_DMVX.AutoSize = true;
            this.LB_DMVX.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_DMVX.Location = new System.Drawing.Point(416, 40);
            this.LB_DMVX.Name = "LB_DMVX";
            this.LB_DMVX.Size = new System.Drawing.Size(403, 65);
            this.LB_DMVX.TabIndex = 1;
            this.LB_DMVX.Text = "Đặt Mua Vắc Xin";
            // 
            // GB_ThongTinVX
            // 
            this.GB_ThongTinVX.Controls.Add(this.BT_ThemCTHD);
            this.GB_ThongTinVX.Controls.Add(this.Num_SoLuong);
            this.GB_ThongTinVX.Controls.Add(this.TB_GiaVX);
            this.GB_ThongTinVX.Controls.Add(this.TB_TenVX);
            this.GB_ThongTinVX.Controls.Add(this.TB_MaVX);
            this.GB_ThongTinVX.Controls.Add(this.LB_SoLuong);
            this.GB_ThongTinVX.Controls.Add(this.LB_GiaVX);
            this.GB_ThongTinVX.Controls.Add(this.LB_TenVX);
            this.GB_ThongTinVX.Controls.Add(this.LB_MaVX);
            this.GB_ThongTinVX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GB_ThongTinVX.Location = new System.Drawing.Point(31, 585);
            this.GB_ThongTinVX.Name = "GB_ThongTinVX";
            this.GB_ThongTinVX.Size = new System.Drawing.Size(1173, 334);
            this.GB_ThongTinVX.TabIndex = 2;
            this.GB_ThongTinVX.TabStop = false;
            this.GB_ThongTinVX.Text = "Thông tin Đặt mua";
            // 
            // LB_MaVX
            // 
            this.LB_MaVX.AutoSize = true;
            this.LB_MaVX.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_MaVX.Location = new System.Drawing.Point(37, 76);
            this.LB_MaVX.Name = "LB_MaVX";
            this.LB_MaVX.Size = new System.Drawing.Size(121, 30);
            this.LB_MaVX.TabIndex = 0;
            this.LB_MaVX.Text = "Mã Vắc Xin";
            // 
            // LB_TenVX
            // 
            this.LB_TenVX.AutoSize = true;
            this.LB_TenVX.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_TenVX.Location = new System.Drawing.Point(37, 143);
            this.LB_TenVX.Name = "LB_TenVX";
            this.LB_TenVX.Size = new System.Drawing.Size(124, 30);
            this.LB_TenVX.TabIndex = 1;
            this.LB_TenVX.Text = "Tên Vắc Xin";
            // 
            // LB_GiaVX
            // 
            this.LB_GiaVX.AutoSize = true;
            this.LB_GiaVX.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_GiaVX.Location = new System.Drawing.Point(37, 208);
            this.LB_GiaVX.Name = "LB_GiaVX";
            this.LB_GiaVX.Size = new System.Drawing.Size(88, 30);
            this.LB_GiaVX.TabIndex = 2;
            this.LB_GiaVX.Text = "Đơn giá";
            // 
            // LB_SoLuong
            // 
            this.LB_SoLuong.AutoSize = true;
            this.LB_SoLuong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_SoLuong.Location = new System.Drawing.Point(37, 280);
            this.LB_SoLuong.Name = "LB_SoLuong";
            this.LB_SoLuong.Size = new System.Drawing.Size(100, 30);
            this.LB_SoLuong.TabIndex = 3;
            this.LB_SoLuong.Text = "Số lượng";
            // 
            // TB_MaVX
            // 
            this.TB_MaVX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_MaVX.Location = new System.Drawing.Point(184, 71);
            this.TB_MaVX.Name = "TB_MaVX";
            this.TB_MaVX.Size = new System.Drawing.Size(127, 39);
            this.TB_MaVX.TabIndex = 4;
            this.TB_MaVX.TextChanged += new System.EventHandler(this.TB_MaVX_TextChanged);
            // 
            // TB_TenVX
            // 
            this.TB_TenVX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_TenVX.Location = new System.Drawing.Point(184, 138);
            this.TB_TenVX.Name = "TB_TenVX";
            this.TB_TenVX.Size = new System.Drawing.Size(604, 39);
            this.TB_TenVX.TabIndex = 5;
            // 
            // TB_GiaVX
            // 
            this.TB_GiaVX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_GiaVX.Location = new System.Drawing.Point(184, 203);
            this.TB_GiaVX.Name = "TB_GiaVX";
            this.TB_GiaVX.Size = new System.Drawing.Size(271, 39);
            this.TB_GiaVX.TabIndex = 6;
            // 
            // Num_SoLuong
            // 
            this.Num_SoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num_SoLuong.Location = new System.Drawing.Point(184, 276);
            this.Num_SoLuong.Name = "Num_SoLuong";
            this.Num_SoLuong.Size = new System.Drawing.Size(180, 39);
            this.Num_SoLuong.TabIndex = 7;
            this.Num_SoLuong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BT_ThemCTHD
            // 
            this.BT_ThemCTHD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_ThemCTHD.Location = new System.Drawing.Point(928, 143);
            this.BT_ThemCTHD.Name = "BT_ThemCTHD";
            this.BT_ThemCTHD.Size = new System.Drawing.Size(239, 69);
            this.BT_ThemCTHD.TabIndex = 8;
            this.BT_ThemCTHD.Text = "Thêm vào đơn hàng";
            this.BT_ThemCTHD.UseVisualStyleBackColor = true;
            this.BT_ThemCTHD.Click += new System.EventHandler(this.BT_ThemCTHD_Click);
            // 
            // BT_TroLai
            // 
            this.BT_TroLai.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_TroLai.Location = new System.Drawing.Point(793, 941);
            this.BT_TroLai.Name = "BT_TroLai";
            this.BT_TroLai.Size = new System.Drawing.Size(180, 79);
            this.BT_TroLai.TabIndex = 3;
            this.BT_TroLai.Text = "Trở lại";
            this.BT_TroLai.UseVisualStyleBackColor = true;
            this.BT_TroLai.Click += new System.EventHandler(this.BT_TroLai_Click);
            // 
            // BT_Tieptuc
            // 
            this.BT_Tieptuc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Tieptuc.Location = new System.Drawing.Point(1018, 941);
            this.BT_Tieptuc.Name = "BT_Tieptuc";
            this.BT_Tieptuc.Size = new System.Drawing.Size(180, 79);
            this.BT_Tieptuc.TabIndex = 4;
            this.BT_Tieptuc.Text = "Tiếp tục";
            this.BT_Tieptuc.UseVisualStyleBackColor = true;
            this.BT_Tieptuc.Click += new System.EventHandler(this.BT_Tieptuc_Click);
            // 
            // GUI_KH_TaoLuuDMVX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 1032);
            this.Controls.Add(this.BT_Tieptuc);
            this.Controls.Add(this.BT_TroLai);
            this.Controls.Add(this.GB_ThongTinVX);
            this.Controls.Add(this.LB_DMVX);
            this.Controls.Add(this.DTGV_DSVX);
            this.Name = "GUI_KH_TaoLuuDMVX";
            this.Text = "GUI_KH_TaoLuuDMVX";
            this.Load += new System.EventHandler(this.GUI_KH_TaoLuuDMVX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DSVX)).EndInit();
            this.GB_ThongTinVX.ResumeLayout(false);
            this.GB_ThongTinVX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV_DSVX;
        private System.Windows.Forms.Label LB_DMVX;
        private System.Windows.Forms.GroupBox GB_ThongTinVX;
        private System.Windows.Forms.NumericUpDown Num_SoLuong;
        private System.Windows.Forms.TextBox TB_GiaVX;
        private System.Windows.Forms.TextBox TB_TenVX;
        private System.Windows.Forms.TextBox TB_MaVX;
        private System.Windows.Forms.Label LB_SoLuong;
        private System.Windows.Forms.Label LB_GiaVX;
        private System.Windows.Forms.Label LB_TenVX;
        private System.Windows.Forms.Label LB_MaVX;
        private System.Windows.Forms.Button BT_ThemCTHD;
        private System.Windows.Forms.Button BT_TroLai;
        private System.Windows.Forms.Button BT_Tieptuc;
    }
}