namespace GUI_NHOM7_DOANCK
{
    partial class GUI_ThanhToanTienMat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_paymentId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_paid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picker_dateofpayment = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_customerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "THANH TOÁN BẰNG TIỀN MẶT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_paymentId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_paid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.picker_dateofpayment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_total);
            this.groupBox1.Controls.Add(this.tb_customerId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(88, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thanh toán";
            // 
            // tb_paymentId
            // 
            this.tb_paymentId.Location = new System.Drawing.Point(191, 22);
            this.tb_paymentId.Name = "tb_paymentId";
            this.tb_paymentId.Size = new System.Drawing.Size(200, 23);
            this.tb_paymentId.TabIndex = 13;
            this.tb_paymentId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(27, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã thanh toán";
            this.label6.Visible = false;
            // 
            // tb_paid
            // 
            this.tb_paid.Location = new System.Drawing.Point(191, 154);
            this.tb_paid.Name = "tb_paid";
            this.tb_paid.Size = new System.Drawing.Size(200, 23);
            this.tb_paid.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số tiền trả";
            // 
            // picker_dateofpayment
            // 
            this.picker_dateofpayment.Location = new System.Drawing.Point(191, 210);
            this.picker_dateofpayment.Name = "picker_dateofpayment";
            this.picker_dateofpayment.Size = new System.Drawing.Size(200, 23);
            this.picker_dateofpayment.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày thanh toán";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(191, 101);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(200, 23);
            this.tb_total.TabIndex = 7;
            // 
            // tb_customerId
            // 
            this.tb_customerId.Location = new System.Drawing.Point(191, 52);
            this.tb_customerId.Name = "tb_customerId";
            this.tb_customerId.Size = new System.Drawing.Size(200, 23);
            this.tb_customerId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã khách hàng";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_checkout.Location = new System.Drawing.Point(458, 363);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(161, 39);
            this.btn_checkout.TabIndex = 6;
            this.btn_checkout.Text = "Thanh toán";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(627, 363);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(161, 39);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // GUI_ThanhToanTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_ThanhToanTienMat";
            this.Text = "Thanh toán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker picker_dateofpayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_customerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_cancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tb_paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_paymentId;
        private System.Windows.Forms.Label label6;
    }
}