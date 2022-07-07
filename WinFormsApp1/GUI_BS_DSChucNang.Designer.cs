
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_BS_DSChucNang
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
            this.button_DS_TraCuuHSBA = new System.Windows.Forms.Button();
            this.button_DangKiLichRanh = new System.Windows.Forms.Button();
            this.button_PhanCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_welcome.Location = new System.Drawing.Point(108, 60);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(165, 37);
            this.label_welcome.TabIndex = 1;
            this.label_welcome.Text = "Chào Mừng!";
            // 
            // button_DS_TraCuuHSBA
            // 
            this.button_DS_TraCuuHSBA.Location = new System.Drawing.Point(108, 133);
            this.button_DS_TraCuuHSBA.Name = "button_DS_TraCuuHSBA";
            this.button_DS_TraCuuHSBA.Size = new System.Drawing.Size(152, 52);
            this.button_DS_TraCuuHSBA.TabIndex = 3;
            this.button_DS_TraCuuHSBA.Text = "Tra Cứu Hồ Sơ Bệnh Án";
            this.button_DS_TraCuuHSBA.UseVisualStyleBackColor = true;
            this.button_DS_TraCuuHSBA.Click += new System.EventHandler(this.button_DS_TraCuuHSBA_Click);
            // 
            // button_DangKiLichRanh
            // 
            this.button_DangKiLichRanh.Location = new System.Drawing.Point(108, 223);
            this.button_DangKiLichRanh.Name = "button_DangKiLichRanh";
            this.button_DangKiLichRanh.Size = new System.Drawing.Size(152, 52);
            this.button_DangKiLichRanh.TabIndex = 5;
            this.button_DangKiLichRanh.Text = "Đăng Kí Lịch Rảnh";
            this.button_DangKiLichRanh.UseVisualStyleBackColor = true;
            this.button_DangKiLichRanh.Click += new System.EventHandler(this.button_DangKiLichRanh_Click);
            // 
            // button_PhanCong
            // 
            this.button_PhanCong.Location = new System.Drawing.Point(108, 312);
            this.button_PhanCong.Name = "button_PhanCong";
            this.button_PhanCong.Size = new System.Drawing.Size(152, 52);
            this.button_PhanCong.TabIndex = 8;
            this.button_PhanCong.Text = "Xem Phân Công Lịch Làm Việc";
            this.button_PhanCong.UseVisualStyleBackColor = true;
            this.button_PhanCong.Click += new System.EventHandler(this.button_PhanCong_Click);
            // 
            // GUI_BS_DSChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.button_PhanCong);
            this.Controls.Add(this.button_DangKiLichRanh);
            this.Controls.Add(this.button_DS_TraCuuHSBA);
            this.Controls.Add(this.label_welcome);
            this.Name = "GUI_BS_DSChucNang";
            this.Text = "GUI_BS_DSChucNang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_DS_TraCuuHSBA;
        private System.Windows.Forms.Button button_DangKiLichRanh;
        private System.Windows.Forms.Button button_PhanCong;
    }
}