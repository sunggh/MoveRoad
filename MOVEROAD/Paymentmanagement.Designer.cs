namespace MOVEROAD
{
    partial class Paymentmanagement
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
            this.btn_overtime = new System.Windows.Forms.Button();
            this.lv_rivise = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.basicPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.overtimePay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nighttimePay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.holidayPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deduction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actualPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_deductioninfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "지급 급여 확인";
            // 
            // btn_overtime
            // 
            this.btn_overtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_overtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_overtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overtime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_overtime.FlatAppearance.BorderSize = 0;
            this.btn_overtime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_overtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overtime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_overtime.ForeColor = System.Drawing.Color.White;
            this.btn_overtime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_overtime.Location = new System.Drawing.Point(652, 26);
            this.btn_overtime.Name = "btn_overtime";
            this.btn_overtime.Size = new System.Drawing.Size(81, 23);
            this.btn_overtime.TabIndex = 4;
            this.btn_overtime.Text = "초과 근무";
            this.btn_overtime.UseVisualStyleBackColor = false;
            this.btn_overtime.Click += new System.EventHandler(this.btn_overtime_Click);
            // 
            // lv_rivise
            // 
            this.lv_rivise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lv_rivise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_rivise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.date,
            this.basicPay,
            this.overtimePay,
            this.nighttimePay,
            this.holidayPay,
            this.totalPay,
            this.deduction,
            this.actualPay});
            this.lv_rivise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lv_rivise.FullRowSelect = true;
            this.lv_rivise.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_rivise.HideSelection = false;
            this.lv_rivise.Location = new System.Drawing.Point(12, 55);
            this.lv_rivise.Name = "lv_rivise";
            this.lv_rivise.Size = new System.Drawing.Size(721, 329);
            this.lv_rivise.TabIndex = 6;
            this.lv_rivise.UseCompatibleStateImageBehavior = false;
            this.lv_rivise.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 63;
            // 
            // date
            // 
            this.date.Text = "날짜";
            this.date.Width = 139;
            // 
            // basicPay
            // 
            this.basicPay.Text = "기본급";
            this.basicPay.Width = 78;
            // 
            // overtimePay
            // 
            this.overtimePay.Text = "초과수당";
            this.overtimePay.Width = 76;
            // 
            // nighttimePay
            // 
            this.nighttimePay.Text = "야간수당";
            this.nighttimePay.Width = 75;
            // 
            // holidayPay
            // 
            this.holidayPay.Text = "휴일수당";
            this.holidayPay.Width = 70;
            // 
            // totalPay
            // 
            this.totalPay.Text = "총급여";
            this.totalPay.Width = 79;
            // 
            // deduction
            // 
            this.deduction.Text = "공제";
            this.deduction.Width = 63;
            // 
            // actualPay
            // 
            this.actualPay.Text = "실급여";
            this.actualPay.Width = 76;
            // 
            // buttonInc
            // 
            this.buttonInc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonInc.FlatAppearance.BorderSize = 0;
            this.buttonInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonInc.ForeColor = System.Drawing.Color.White;
            this.buttonInc.Location = new System.Drawing.Point(363, 16);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(24, 26);
            this.buttonInc.TabIndex = 8;
            this.buttonInc.Text = "▲";
            this.buttonInc.UseVisualStyleBackColor = false;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonDec.FlatAppearance.BorderSize = 0;
            this.buttonDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonDec.ForeColor = System.Drawing.Color.White;
            this.buttonDec.Location = new System.Drawing.Point(393, 16);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(24, 26);
            this.buttonDec.TabIndex = 9;
            this.buttonDec.Text = "▼";
            this.buttonDec.UseVisualStyleBackColor = false;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(252, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "현재 년-월";
            // 
            // label_deductioninfo
            // 
            this.label_deductioninfo.AutoSize = true;
            this.label_deductioninfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_deductioninfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_deductioninfo.Location = new System.Drawing.Point(513, 30);
            this.label_deductioninfo.Name = "label_deductioninfo";
            this.label_deductioninfo.Size = new System.Drawing.Size(91, 15);
            this.label_deductioninfo.TabIndex = 11;
            this.label_deductioninfo.Text = "※ 세금 공제란?";
            this.label_deductioninfo.Click += new System.EventHandler(this.label_deductioninfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MOVEROAD.Properties.Resources.calendar;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(219, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Paymentmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_deductioninfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonInc);
            this.Controls.Add(this.lv_rivise);
            this.Controls.Add(this.btn_overtime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paymentmanagement";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_overtime;
        public System.Windows.Forms.ListView lv_rivise;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader basicPay;
        private System.Windows.Forms.ColumnHeader overtimePay;
        private System.Windows.Forms.ColumnHeader nighttimePay;
        private System.Windows.Forms.ColumnHeader holidayPay;
        private System.Windows.Forms.ColumnHeader totalPay;
        private System.Windows.Forms.ColumnHeader deduction;
        private System.Windows.Forms.ColumnHeader actualPay;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_deductioninfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}