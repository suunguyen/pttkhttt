namespace GUI_NHOM7_DOANCK
{
    partial class GUI_HinhThucThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_full = new System.Windows.Forms.Button();
            this.btn_apart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÌNH THỨC THANH TOÁN";
            // 
            // btn_full
            // 
            this.btn_full.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_full.Location = new System.Drawing.Point(189, 153);
            this.btn_full.Name = "btn_full";
            this.btn_full.Size = new System.Drawing.Size(175, 68);
            this.btn_full.TabIndex = 1;
            this.btn_full.Text = "Trả hết";
            this.btn_full.UseVisualStyleBackColor = true;
            // 
            // btn_apart
            // 
            this.btn_apart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_apart.Location = new System.Drawing.Point(400, 153);
            this.btn_apart.Name = "btn_apart";
            this.btn_apart.Size = new System.Drawing.Size(175, 68);
            this.btn_apart.TabIndex = 2;
            this.btn_apart.Text = "Trả góp";
            this.btn_apart.UseVisualStyleBackColor = true;
            // 
            // GUI_Menu_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_apart);
            this.Controls.Add(this.btn_full);
            this.Controls.Add(this.label1);
            this.Name = "GUI_Menu_ThanhToan";
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_full;
        private System.Windows.Forms.Button btn_apart;
    }
}