
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_NV_XemLichLamViec
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_LichLamViec = new System.Windows.Forms.DataGridView();
            this.TB_MaNV = new System.Windows.Forms.TextBox();
            this.LB_MaNV = new System.Windows.Forms.Label();
            this.BT_XemLich = new System.Windows.Forms.Button();
            this.BT_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_LichLamViec
            // 
            this.DGV_LichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LichLamViec.Location = new System.Drawing.Point(29, 97);
            this.DGV_LichLamViec.Name = "DGV_LichLamViec";
            this.DGV_LichLamViec.RowHeadersWidth = 62;
            this.DGV_LichLamViec.RowTemplate.Height = 33;
            this.DGV_LichLamViec.Size = new System.Drawing.Size(735, 275);
            this.DGV_LichLamViec.TabIndex = 0;
            // 
            // TB_MaNV
            // 
            this.TB_MaNV.Location = new System.Drawing.Point(223, 34);
            this.TB_MaNV.Name = "TB_MaNV";
            this.TB_MaNV.Size = new System.Drawing.Size(186, 31);
            this.TB_MaNV.TabIndex = 1;
            // 
            // LB_MaNV
            // 
            this.LB_MaNV.AutoSize = true;
            this.LB_MaNV.Location = new System.Drawing.Point(29, 37);
            this.LB_MaNV.Name = "LB_MaNV";
            this.LB_MaNV.Size = new System.Drawing.Size(170, 25);
            this.LB_MaNV.TabIndex = 2;
            this.LB_MaNV.Text = "Nhập mã nhân viên:";
            // 
            // BT_XemLich
            // 
            this.BT_XemLich.Location = new System.Drawing.Point(545, 32);
            this.BT_XemLich.Name = "BT_XemLich";
            this.BT_XemLich.Size = new System.Drawing.Size(112, 34);
            this.BT_XemLich.TabIndex = 3;
            this.BT_XemLich.Text = "Xem lịch";
            this.BT_XemLich.UseVisualStyleBackColor = true;
            this.BT_XemLich.Click += new System.EventHandler(this.BT_XemLich_Click);
            // 
            // BT_Back
            // 
            this.BT_Back.Location = new System.Drawing.Point(652, 404);
            this.BT_Back.Name = "BT_Back";
            this.BT_Back.Size = new System.Drawing.Size(112, 34);
            this.BT_Back.TabIndex = 4;
            this.BT_Back.Text = "Trở lại";
            this.BT_Back.UseVisualStyleBackColor = true;
            this.BT_Back.Click += new System.EventHandler(this.BT_Back_Click);
            // 
            // GUI_NV_XemLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Back);
            this.Controls.Add(this.BT_XemLich);
            this.Controls.Add(this.LB_MaNV);
            this.Controls.Add(this.TB_MaNV);
            this.Controls.Add(this.DGV_LichLamViec);
            this.Name = "GUI_NV_XemLichLamViec";
            this.Text = "Xem lịch làm việc";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_LichLamViec;
        private System.Windows.Forms.TextBox TB_MaNV;
        private System.Windows.Forms.Label LB_MaNV;
        private System.Windows.Forms.Button BT_XemLich;
        private System.Windows.Forms.Button BT_Back;
    }
}

