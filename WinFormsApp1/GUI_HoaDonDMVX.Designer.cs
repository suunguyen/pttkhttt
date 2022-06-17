
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_HoaDonDMVX
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
            this.DTGV_CTHD = new System.Windows.Forms.DataGridView();
            this.DTGV_TotalBill = new System.Windows.Forms.DataGridView();
            this.LB_DMVX = new System.Windows.Forms.Label();
            this.BT_Trolai = new System.Windows.Forms.Button();
            this.BT_Dathang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_TotalBill)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV_CTHD
            // 
            this.DTGV_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_CTHD.Location = new System.Drawing.Point(28, 109);
            this.DTGV_CTHD.Name = "DTGV_CTHD";
            this.DTGV_CTHD.RowHeadersWidth = 62;
            this.DTGV_CTHD.RowTemplate.Height = 33;
            this.DTGV_CTHD.Size = new System.Drawing.Size(1074, 485);
            this.DTGV_CTHD.TabIndex = 0;
            this.DTGV_CTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CTHĐ_CellContentClick);
            // 
            // DTGV_TotalBill
            // 
            this.DTGV_TotalBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_TotalBill.Location = new System.Drawing.Point(28, 600);
            this.DTGV_TotalBill.Name = "DTGV_TotalBill";
            this.DTGV_TotalBill.RowHeadersWidth = 62;
            this.DTGV_TotalBill.RowTemplate.Height = 33;
            this.DTGV_TotalBill.Size = new System.Drawing.Size(1074, 150);
            this.DTGV_TotalBill.TabIndex = 1;
            this.DTGV_TotalBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_TotalBill_CellContentClick);
            // 
            // LB_DMVX
            // 
            this.LB_DMVX.AutoSize = true;
            this.LB_DMVX.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_DMVX.Location = new System.Drawing.Point(353, 21);
            this.LB_DMVX.Name = "LB_DMVX";
            this.LB_DMVX.Size = new System.Drawing.Size(403, 65);
            this.LB_DMVX.TabIndex = 2;
            this.LB_DMVX.Text = "Đặt Mua Vắc Xin";
            // 
            // BT_Trolai
            // 
            this.BT_Trolai.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Trolai.Location = new System.Drawing.Point(683, 804);
            this.BT_Trolai.Name = "BT_Trolai";
            this.BT_Trolai.Size = new System.Drawing.Size(187, 89);
            this.BT_Trolai.TabIndex = 5;
            this.BT_Trolai.Text = "Trở lại";
            this.BT_Trolai.UseVisualStyleBackColor = true;
            this.BT_Trolai.Click += new System.EventHandler(this.BT_Trolai_Click);
            // 
            // BT_Dathang
            // 
            this.BT_Dathang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Dathang.Location = new System.Drawing.Point(915, 804);
            this.BT_Dathang.Name = "BT_Dathang";
            this.BT_Dathang.Size = new System.Drawing.Size(187, 89);
            this.BT_Dathang.TabIndex = 6;
            this.BT_Dathang.Text = "Đặt hàng";
            this.BT_Dathang.UseVisualStyleBackColor = true;
            this.BT_Dathang.Click += new System.EventHandler(this.BT_Dathang_Click);
            // 
            // GUI_HoaDonDMVX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 905);
            this.Controls.Add(this.BT_Dathang);
            this.Controls.Add(this.BT_Trolai);
            this.Controls.Add(this.LB_DMVX);
            this.Controls.Add(this.DTGV_TotalBill);
            this.Controls.Add(this.DTGV_CTHD);
            this.Name = "GUI_HoaDonDMVX";
            this.Text = "GUI_HoaDonDMVX";
            this.Load += new System.EventHandler(this.GUI_HoaDonDMVX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_TotalBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV_CTHD;
        private System.Windows.Forms.DataGridView DTGV_TotalBill;
        private System.Windows.Forms.Label LB_DMVX;
        private System.Windows.Forms.Button BT_Trolai;
        private System.Windows.Forms.Button BT_Dathang;
    }
}