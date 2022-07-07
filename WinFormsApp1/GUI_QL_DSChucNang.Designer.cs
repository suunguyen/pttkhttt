
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_QL_DSChucNang
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_DangKiLichRanh = new System.Windows.Forms.Button();
            this.button_ThongKePhieuDatMua = new System.Windows.Forms.Button();
            this.button_PhanCong = new System.Windows.Forms.Button();
            this.BT_DuyetDMVX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_welcome.Location = new System.Drawing.Point(114, 49);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(165, 37);
            this.label_welcome.TabIndex = 1;
            this.label_welcome.Text = "Chào Mừng!";
            // 
            // button_DangKiLichRanh
            // 
            this.button_DangKiLichRanh.Location = new System.Drawing.Point(114, 118);
            this.button_DangKiLichRanh.Name = "button_DangKiLichRanh";
            this.button_DangKiLichRanh.Size = new System.Drawing.Size(152, 52);
            this.button_DangKiLichRanh.TabIndex = 5;
            this.button_DangKiLichRanh.Text = "Đăng Kí Lịch Rảnh";
            this.button_DangKiLichRanh.UseVisualStyleBackColor = true;
            this.button_DangKiLichRanh.Click += new System.EventHandler(this.button_DangKiLichRanh_Click);
            // 
            // button_ThongKePhieuDatMua
            // 
            this.button_ThongKePhieuDatMua.Location = new System.Drawing.Point(114, 198);
            this.button_ThongKePhieuDatMua.Name = "button_ThongKePhieuDatMua";
            this.button_ThongKePhieuDatMua.Size = new System.Drawing.Size(152, 52);
            this.button_ThongKePhieuDatMua.TabIndex = 7;
            this.button_ThongKePhieuDatMua.Text = "Thống Kê Phiếu Đặt Mua";
            this.button_ThongKePhieuDatMua.UseVisualStyleBackColor = true;
            this.button_ThongKePhieuDatMua.Click += new System.EventHandler(this.button_ThongKePhieuDatMua_Click);
            // 
            // button_PhanCong
            // 
            this.button_PhanCong.Location = new System.Drawing.Point(114, 280);
            this.button_PhanCong.Name = "button_PhanCong";
            this.button_PhanCong.Size = new System.Drawing.Size(152, 52);
            this.button_PhanCong.TabIndex = 8;
            this.button_PhanCong.Text = "Xem Phân Công Lịch Làm Việc";
            this.button_PhanCong.UseVisualStyleBackColor = true;
            this.button_PhanCong.Click += new System.EventHandler(this.button_PhanCong_Click);
            // 
            // BT_DuyetDMVX
            // 
            this.BT_DuyetDMVX.Location = new System.Drawing.Point(114, 364);
            this.BT_DuyetDMVX.Name = "BT_DuyetDMVX";
            this.BT_DuyetDMVX.Size = new System.Drawing.Size(152, 52);
            this.BT_DuyetDMVX.TabIndex = 10;
            this.BT_DuyetDMVX.Text = "Duyệt Đơn Đặt Mua Vắc Xin";
            this.BT_DuyetDMVX.UseVisualStyleBackColor = true;
            this.BT_DuyetDMVX.Click += new System.EventHandler(this.BT_DuyetDMVX_Click);
            // 
            // GUI_QL_DSChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.BT_DuyetDMVX);
            this.Controls.Add(this.button_PhanCong);
            this.Controls.Add(this.button_ThongKePhieuDatMua);
            this.Controls.Add(this.button_DangKiLichRanh);
            this.Controls.Add(this.label_welcome);
            this.Name = "GUI_QL_DSChucNang";
            this.Text = "GUI_QL_DSChucNang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_DangKiLichRanh;
        private System.Windows.Forms.Button button_ThongKePhieuDatMua;
        private System.Windows.Forms.Button button_PhanCong;
        private System.Windows.Forms.Button BT_DuyetDMVX;
    }
}