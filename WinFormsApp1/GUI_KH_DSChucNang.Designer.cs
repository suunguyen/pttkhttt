
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_KH_DSChucNang
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
            this.button_DKTC = new System.Windows.Forms.Button();
            this.button_PhieuDKTC = new System.Windows.Forms.Button();
            this.button_ChungNhan = new System.Windows.Forms.Button();
            this.button_DatMuaVaccine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_welcome.Location = new System.Drawing.Point(171, 38);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(165, 37);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Chào Mừng!";
            // 
            // button_DKTC
            // 
            this.button_DKTC.Location = new System.Drawing.Point(51, 108);
            this.button_DKTC.Name = "button_DKTC";
            this.button_DKTC.Size = new System.Drawing.Size(152, 52);
            this.button_DKTC.TabIndex = 1;
            this.button_DKTC.Text = "Đăng Kí Tiêm Chủng";
            this.button_DKTC.UseVisualStyleBackColor = true;
            this.button_DKTC.Click += new System.EventHandler(this.button_DKTC_Click);
            // 
            // button_PhieuDKTC
            // 
            this.button_PhieuDKTC.Location = new System.Drawing.Point(288, 108);
            this.button_PhieuDKTC.Name = "button_PhieuDKTC";
            this.button_PhieuDKTC.Size = new System.Drawing.Size(152, 52);
            this.button_PhieuDKTC.TabIndex = 2;
            this.button_PhieuDKTC.Text = "Xem Phiếu Đăng Kí Tiêm Chủng";
            this.button_PhieuDKTC.UseVisualStyleBackColor = true;
            this.button_PhieuDKTC.Click += new System.EventHandler(this.button_PhieuDKTC_Click);
            // 
            // button_ChungNhan
            // 
            this.button_ChungNhan.Location = new System.Drawing.Point(51, 197);
            this.button_ChungNhan.Name = "button_ChungNhan";
            this.button_ChungNhan.Size = new System.Drawing.Size(152, 52);
            this.button_ChungNhan.TabIndex = 3;
            this.button_ChungNhan.Text = "Xem Chứng Nhận Tiêm Chủng";
            this.button_ChungNhan.UseVisualStyleBackColor = true;
            this.button_ChungNhan.Click += new System.EventHandler(this.button_ChungNhan_Click);
            // 
            // button_DatMuaVaccine
            // 
            this.button_DatMuaVaccine.Location = new System.Drawing.Point(288, 197);
            this.button_DatMuaVaccine.Name = "button_DatMuaVaccine";
            this.button_DatMuaVaccine.Size = new System.Drawing.Size(152, 52);
            this.button_DatMuaVaccine.TabIndex = 4;
            this.button_DatMuaVaccine.Text = "Đặt Mua Vaccine";
            this.button_DatMuaVaccine.UseVisualStyleBackColor = true;
            this.button_DatMuaVaccine.Click += new System.EventHandler(this.button_DatMuaVaccine_Click);
            // 
            // GUI_KH_DSChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 311);
            this.Controls.Add(this.button_DatMuaVaccine);
            this.Controls.Add(this.button_ChungNhan);
            this.Controls.Add(this.button_PhieuDKTC);
            this.Controls.Add(this.button_DKTC);
            this.Controls.Add(this.label_welcome);
            this.Name = "GUI_KH_DSChucNang";
            this.Text = "GUI_KH_DSChucNang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_DKTC;
        private System.Windows.Forms.Button button_PhieuDKTC;
        private System.Windows.Forms.Button button_ChungNhan;
        private System.Windows.Forms.Button button_DatMuaVaccine;
    }
}