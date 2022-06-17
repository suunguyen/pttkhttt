
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_NV_ThongKePDM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_TK = new System.Windows.Forms.Button();
            this.LB_Nam = new System.Windows.Forms.Label();
            this.LB_Thang = new System.Windows.Forms.Label();
            this.Num_Nam = new System.Windows.Forms.NumericUpDown();
            this.CbB_Thang = new System.Windows.Forms.ComboBox();
            this.DTGV_TK = new System.Windows.Forms.DataGridView();
            this.DTGV_DSDM = new System.Windows.Forms.DataGridView();
            this.LB_PDM = new System.Windows.Forms.Label();
            this.BT_Trolai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Nam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_TK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DSDM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_TK);
            this.groupBox1.Controls.Add(this.LB_Nam);
            this.groupBox1.Controls.Add(this.LB_Thang);
            this.groupBox1.Controls.Add(this.Num_Nam);
            this.groupBox1.Controls.Add(this.CbB_Thang);
            this.groupBox1.Controls.Add(this.DTGV_TK);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 569);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 313);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // BT_TK
            // 
            this.BT_TK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_TK.Location = new System.Drawing.Point(66, 231);
            this.BT_TK.Name = "BT_TK";
            this.BT_TK.Size = new System.Drawing.Size(194, 59);
            this.BT_TK.TabIndex = 8;
            this.BT_TK.Text = "Thống kê";
            this.BT_TK.UseVisualStyleBackColor = true;
            this.BT_TK.Click += new System.EventHandler(this.BT_TK_Click);
            // 
            // LB_Nam
            // 
            this.LB_Nam.AutoSize = true;
            this.LB_Nam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Nam.Location = new System.Drawing.Point(18, 168);
            this.LB_Nam.Name = "LB_Nam";
            this.LB_Nam.Size = new System.Drawing.Size(65, 32);
            this.LB_Nam.TabIndex = 7;
            this.LB_Nam.Text = "Năm";
            // 
            // LB_Thang
            // 
            this.LB_Thang.AutoSize = true;
            this.LB_Thang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Thang.Location = new System.Drawing.Point(18, 76);
            this.LB_Thang.Name = "LB_Thang";
            this.LB_Thang.Size = new System.Drawing.Size(81, 32);
            this.LB_Thang.TabIndex = 6;
            this.LB_Thang.Text = "Tháng";
            // 
            // Num_Nam
            // 
            this.Num_Nam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num_Nam.Location = new System.Drawing.Point(105, 166);
            this.Num_Nam.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.Num_Nam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Num_Nam.Name = "Num_Nam";
            this.Num_Nam.Size = new System.Drawing.Size(180, 39);
            this.Num_Nam.TabIndex = 5;
            this.Num_Nam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // CbB_Thang
            // 
            this.CbB_Thang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbB_Thang.FormattingEnabled = true;
            this.CbB_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "ALL"});
            this.CbB_Thang.Location = new System.Drawing.Point(105, 73);
            this.CbB_Thang.Name = "CbB_Thang";
            this.CbB_Thang.Size = new System.Drawing.Size(180, 40);
            this.CbB_Thang.TabIndex = 4;
            // 
            // DTGV_TK
            // 
            this.DTGV_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_TK.Location = new System.Drawing.Point(444, 107);
            this.DTGV_TK.Name = "DTGV_TK";
            this.DTGV_TK.RowHeadersWidth = 62;
            this.DTGV_TK.RowTemplate.Height = 33;
            this.DTGV_TK.Size = new System.Drawing.Size(540, 129);
            this.DTGV_TK.TabIndex = 3;
            // 
            // DTGV_DSDM
            // 
            this.DTGV_DSDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_DSDM.Location = new System.Drawing.Point(12, 114);
            this.DTGV_DSDM.Name = "DTGV_DSDM";
            this.DTGV_DSDM.RowHeadersWidth = 62;
            this.DTGV_DSDM.RowTemplate.Height = 33;
            this.DTGV_DSDM.Size = new System.Drawing.Size(1040, 434);
            this.DTGV_DSDM.TabIndex = 7;
            this.DTGV_DSDM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_DSDM_CellContentClick);
            // 
            // LB_PDM
            // 
            this.LB_PDM.AutoSize = true;
            this.LB_PDM.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_PDM.Location = new System.Drawing.Point(338, 25);
            this.LB_PDM.Name = "LB_PDM";
            this.LB_PDM.Size = new System.Drawing.Size(362, 65);
            this.LB_PDM.TabIndex = 6;
            this.LB_PDM.Text = "Phiếu Đặt Mua";
            // 
            // BT_Trolai
            // 
            this.BT_Trolai.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Trolai.Location = new System.Drawing.Point(439, 902);
            this.BT_Trolai.Name = "BT_Trolai";
            this.BT_Trolai.Size = new System.Drawing.Size(165, 75);
            this.BT_Trolai.TabIndex = 10;
            this.BT_Trolai.Text = "Trở lại";
            this.BT_Trolai.UseVisualStyleBackColor = true;
            this.BT_Trolai.Click += new System.EventHandler(this.BT_Trolai_Click_1);
            // 
            // GUI_NV_ThongKePDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 995);
            this.Controls.Add(this.BT_Trolai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTGV_DSDM);
            this.Controls.Add(this.LB_PDM);
            this.Name = "GUI_NV_ThongKePDM";
            this.Text = "GUI_NV_ThongKePDM";
            this.Load += new System.EventHandler(this.GUI_NV_ThongKePDM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Nam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_TK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DSDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_TK;
        private System.Windows.Forms.Label LB_Nam;
        private System.Windows.Forms.Label LB_Thang;
        private System.Windows.Forms.NumericUpDown Num_Nam;
        private System.Windows.Forms.ComboBox CbB_Thang;
        private System.Windows.Forms.DataGridView DTGV_TK;
        private System.Windows.Forms.DataGridView DTGV_DSDM;
        private System.Windows.Forms.Label LB_PDM;
        private System.Windows.Forms.Button BT_Trolai;
    }
}