
namespace GUI_NHOM7_DOANCK
{
    partial class GUI_NV_DangKiLichRanh
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
            System.Windows.Forms.Button BT_DKI;
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_LichDangKi = new System.Windows.Forms.DataGridView();
            this.BT_Back = new System.Windows.Forms.Button();
            this.LB_MaNV = new System.Windows.Forms.Label();
            this.LB_ST = new System.Windows.Forms.Label();
            this.LB_ET = new System.Windows.Forms.Label();
            this.TB_MaNV = new System.Windows.Forms.TextBox();
            this.TB_ST = new System.Windows.Forms.TextBox();
            this.TB_ET = new System.Windows.Forms.TextBox();
            BT_DKI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichDangKi)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_DKI
            // 
            BT_DKI.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BT_DKI.Location = new System.Drawing.Point(659, 400);
            BT_DKI.Name = "BT_DKI";
            BT_DKI.Size = new System.Drawing.Size(112, 34);
            BT_DKI.TabIndex = 3;
            BT_DKI.Text = "Đăng kí";
            BT_DKI.UseVisualStyleBackColor = true;
            BT_DKI.Click += new System.EventHandler(this.BT_DKI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí lịch rảnh";
            // 
            // dataGridView_LichDangKi
            // 
            this.dataGridView_LichDangKi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LichDangKi.Location = new System.Drawing.Point(12, 57);
            this.dataGridView_LichDangKi.Name = "dataGridView_LichDangKi";
            this.dataGridView_LichDangKi.RowHeadersWidth = 62;
            this.dataGridView_LichDangKi.RowTemplate.Height = 33;
            this.dataGridView_LichDangKi.Size = new System.Drawing.Size(776, 177);
            this.dataGridView_LichDangKi.TabIndex = 1;
            this.dataGridView_LichDangKi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BT_Back
            // 
            this.BT_Back.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Back.Location = new System.Drawing.Point(541, 400);
            this.BT_Back.Name = "BT_Back";
            this.BT_Back.Size = new System.Drawing.Size(112, 34);
            this.BT_Back.TabIndex = 2;
            this.BT_Back.Text = "Trở lại";
            this.BT_Back.UseVisualStyleBackColor = true;
            this.BT_Back.Click += new System.EventHandler(this.BT_Back_Click);
            // 
            // LB_MaNV
            // 
            this.LB_MaNV.AutoSize = true;
            this.LB_MaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_MaNV.Location = new System.Drawing.Point(29, 254);
            this.LB_MaNV.Name = "LB_MaNV";
            this.LB_MaNV.Size = new System.Drawing.Size(81, 32);
            this.LB_MaNV.TabIndex = 4;
            this.LB_MaNV.Text = "MaNV";
            // 
            // LB_ST
            // 
            this.LB_ST.AutoSize = true;
            this.LB_ST.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_ST.Location = new System.Drawing.Point(29, 299);
            this.LB_ST.Name = "LB_ST";
            this.LB_ST.Size = new System.Drawing.Size(115, 32);
            this.LB_ST.TabIndex = 5;
            this.LB_ST.Text = "StartTime";
            // 
            // LB_ET
            // 
            this.LB_ET.AutoSize = true;
            this.LB_ET.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_ET.Location = new System.Drawing.Point(29, 344);
            this.LB_ET.Name = "LB_ET";
            this.LB_ET.Size = new System.Drawing.Size(107, 32);
            this.LB_ET.TabIndex = 6;
            this.LB_ET.Text = "EndTime";
            // 
            // TB_MaNV
            // 
            this.TB_MaNV.Location = new System.Drawing.Point(237, 241);
            this.TB_MaNV.Name = "TB_MaNV";
            this.TB_MaNV.Size = new System.Drawing.Size(256, 50);
            this.TB_MaNV.TabIndex = 7;
            // 
            // TB_ST
            // 
            this.TB_ST.Location = new System.Drawing.Point(237, 297);
            this.TB_ST.Name = "TB_ST";
            this.TB_ST.Size = new System.Drawing.Size(256, 50);
            this.TB_ST.TabIndex = 8;
            // 
            // TB_ET
            // 
            this.TB_ET.Location = new System.Drawing.Point(237, 353);
            this.TB_ET.Name = "TB_ET";
            this.TB_ET.Size = new System.Drawing.Size(256, 50);
            this.TB_ET.TabIndex = 9;
            // 
            // GUI_NV_DangKiLichRanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_ET);
            this.Controls.Add(this.TB_ST);
            this.Controls.Add(this.TB_MaNV);
            this.Controls.Add(this.LB_ET);
            this.Controls.Add(this.LB_ST);
            this.Controls.Add(this.LB_MaNV);
            this.Controls.Add(BT_DKI);
            this.Controls.Add(this.BT_Back);
            this.Controls.Add(this.dataGridView_LichDangKi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "GUI_NV_DangKiLichRanh";
            this.Text = "Đăng kí lịch rảnh";
            this.Load += new System.EventHandler(this.GUI_NV_DangKiLichRanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichDangKi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_LichDangKi;
        private System.Windows.Forms.Button BT_Back;
        private System.Windows.Forms.Button BT_DKI;
        private System.Windows.Forms.Label LB_MaNV;
        private System.Windows.Forms.Label LB_ST;
        private System.Windows.Forms.Label LB_ET;
        private System.Windows.Forms.TextBox TB_MaNV;
        private System.Windows.Forms.TextBox TB_ST;
        private System.Windows.Forms.TextBox TB_ET;
    }
}

