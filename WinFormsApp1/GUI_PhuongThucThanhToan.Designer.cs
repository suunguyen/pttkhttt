namespace GUI_NHOM7_DOANCK
{
    partial class GUI_PhuongThucThanhToan
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
            this.btn_credit = new System.Windows.Forms.Button();
            this.btn_cash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_credit
            // 
            this.btn_credit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_credit.Location = new System.Drawing.Point(450, 183);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(175, 68);
            this.btn_credit.TabIndex = 5;
            this.btn_credit.Text = "Chuyển khoản";
            this.btn_credit.UseVisualStyleBackColor = true;
            // 
            // btn_cash
            // 
            this.btn_cash.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cash.Location = new System.Drawing.Point(192, 183);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(175, 68);
            this.btn_cash.TabIndex = 4;
            this.btn_cash.Text = "Tiền mặt";
            this.btn_cash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHƯƠNG THỨC THANH TOÁN";
            // 
            // GUI_PhuongThucThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_credit);
            this.Controls.Add(this.btn_cash);
            this.Controls.Add(this.label1);
            this.Name = "GUI_PhuongThucThanhToan";
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.Label label1;
    }
}