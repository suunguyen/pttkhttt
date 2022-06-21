namespace GUI_NHOM7_DOANCK
{
    partial class GUI_CacDotThanhToan
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
            this.tb_left = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_paid = new System.Windows.Forms.TextBox();
            this.tb_customerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_totaltwonext = new System.Windows.Forms.TextBox();
            this.tb_twonextdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_totalthreenext = new System.Windows.Forms.TextBox();
            this.tb_threenextdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_totalnext = new System.Windows.Forms.TextBox();
            this.tb_nextdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_complete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "CÁC ĐỢT THANH TOÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_left);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_paid);
            this.groupBox1.Controls.Add(this.tb_customerId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thanh toán";
            // 
            // tb_left
            // 
            this.tb_left.Location = new System.Drawing.Point(158, 101);
            this.tb_left.Name = "tb_left";
            this.tb_left.ReadOnly = true;
            this.tb_left.Size = new System.Drawing.Size(200, 23);
            this.tb_left.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tiền còn lại";
            // 
            // tb_paid
            // 
            this.tb_paid.Location = new System.Drawing.Point(158, 65);
            this.tb_paid.Name = "tb_paid";
            this.tb_paid.ReadOnly = true;
            this.tb_paid.Size = new System.Drawing.Size(200, 23);
            this.tb_paid.TabIndex = 7;
            // 
            // tb_customerId
            // 
            this.tb_customerId.Location = new System.Drawing.Point(158, 33);
            this.tb_customerId.Name = "tb_customerId";
            this.tb_customerId.ReadOnly = true;
            this.tb_customerId.Size = new System.Drawing.Size(200, 23);
            this.tb_customerId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tiền trả trước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã khách hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_totaltwonext);
            this.groupBox4.Controls.Add(this.tb_twonextdate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(440, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 101);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đợt 3";
            // 
            // tb_totaltwonext
            // 
            this.tb_totaltwonext.Location = new System.Drawing.Point(158, 65);
            this.tb_totaltwonext.Name = "tb_totaltwonext";
            this.tb_totaltwonext.ReadOnly = true;
            this.tb_totaltwonext.Size = new System.Drawing.Size(200, 23);
            this.tb_totaltwonext.TabIndex = 7;
            // 
            // tb_twonextdate
            // 
            this.tb_twonextdate.Location = new System.Drawing.Point(158, 33);
            this.tb_twonextdate.Name = "tb_twonextdate";
            this.tb_twonextdate.ReadOnly = true;
            this.tb_twonextdate.Size = new System.Drawing.Size(200, 23);
            this.tb_twonextdate.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(27, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Số tiền phải trả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(27, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ngày thanh toán";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_totalthreenext);
            this.groupBox3.Controls.Add(this.tb_threenextdate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(31, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 101);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đợt 2";
            // 
            // tb_totalthreenext
            // 
            this.tb_totalthreenext.Location = new System.Drawing.Point(158, 65);
            this.tb_totalthreenext.Name = "tb_totalthreenext";
            this.tb_totalthreenext.ReadOnly = true;
            this.tb_totalthreenext.Size = new System.Drawing.Size(200, 23);
            this.tb_totalthreenext.TabIndex = 7;
            // 
            // tb_threenextdate
            // 
            this.tb_threenextdate.Location = new System.Drawing.Point(158, 33);
            this.tb_threenextdate.Name = "tb_threenextdate";
            this.tb_threenextdate.ReadOnly = true;
            this.tb_threenextdate.Size = new System.Drawing.Size(200, 23);
            this.tb_threenextdate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số tiền phải trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(27, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày thanh toán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_totalnext);
            this.groupBox2.Controls.Add(this.tb_nextdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(31, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 101);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đợt 1";
            // 
            // tb_totalnext
            // 
            this.tb_totalnext.Location = new System.Drawing.Point(158, 65);
            this.tb_totalnext.Name = "tb_totalnext";
            this.tb_totalnext.ReadOnly = true;
            this.tb_totalnext.Size = new System.Drawing.Size(200, 23);
            this.tb_totalnext.TabIndex = 7;
            // 
            // tb_nextdate
            // 
            this.tb_nextdate.Location = new System.Drawing.Point(158, 33);
            this.tb_nextdate.Name = "tb_nextdate";
            this.tb_nextdate.ReadOnly = true;
            this.tb_nextdate.Size = new System.Drawing.Size(200, 23);
            this.tb_nextdate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(27, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số tiền phải trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày thanh toán";
            // 
            // btn_complete
            // 
            this.btn_complete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_complete.Location = new System.Drawing.Point(637, 360);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(161, 39);
            this.btn_complete.TabIndex = 16;
            this.btn_complete.Text = "Hoàn tất";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // GUI_CacDotThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 426);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_CacDotThanhToan";
            this.Text = "Các đợt thanh toán";
            this.Load += new System.EventHandler(this.GUI_CacDotThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_left;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_paid;
        private System.Windows.Forms.TextBox tb_customerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_totaltwonext;
        private System.Windows.Forms.TextBox tb_twonextdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_totalthreenext;
        private System.Windows.Forms.TextBox tb_threenextdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_totalnext;
        private System.Windows.Forms.TextBox tb_nextdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_complete;
    }
}